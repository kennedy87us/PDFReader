namespace PdfReader.Business
{
    using ExCSS;
    using IronPdf;
    using PdfReader.Business.Contracts;
    using PdfReader.Model;
    using System;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Xml;

    public class PdfParser : IPdfParser
    {
        private string classForFullName;
        private string classForLeftSectionBlocks;
        private string classForRightSectionBlocks;
        private string classForOldCompany;

        public PdfParser() { }

        public Resume Deserialize(string pathFile)
        {
            var pdf = PdfDocument.FromFile(pathFile);
            string html = pdf.ToHtmlString();

            var xmlDoc = new XmlDocument();
            using (var stream = GenerateStreamFromString(html))
            {
                var xmlReader = new XmlTextReader(stream);
                xmlReader.Namespaces = false;
                xmlDoc.Load(xmlReader);
            }
            return ExtractData(xmlDoc);
        }

        private static Stream GenerateStreamFromString(string s)
        {
            var stream = new MemoryStream();
            var writer = new StreamWriter(stream);
            writer.Write(s);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        private static XmlNode GetValidSibling(XmlNode node, string excludeClassName)
        {
            var sibling = node.NextSibling;
            if (sibling == null || sibling.Attributes?["class"] == null || sibling.Attributes?["class"]?.Value == excludeClassName)
            {
                sibling = null;
            }
            return sibling;
        }

        private Resume ExtractData(XmlDocument xmlDoc)
        {
            var result = new Resume();
            var styleNode = xmlDoc.DocumentElement.SelectSingleNode("/html/body/div[@class='pdf-page']/svg/style");

            // identify the classes
            var parser = new StylesheetParser();
            var stylesheet = parser.Parse(styleNode.InnerText);
            var rules = stylesheet.StyleRules.Where(x => !string.IsNullOrWhiteSpace(x.Style.FontSize))
                                             .OrderByDescending(x => Convert.ToDouble(x.Style.FontSize[..^2]));

            classForFullName = (rules.First().Selector as ClassSelector).Class;
            classForRightSectionBlocks = (rules.Skip(1).First().Selector as ClassSelector).Class;
            classForLeftSectionBlocks = (rules.Skip(2).First().Selector as ClassSelector).Class;

            // start to parse data
            var gNode = xmlDoc.DocumentElement.SelectSingleNode("/html/body/div[@class='pdf-page']/svg/g[@stroke-miterlimit='10']");

            var fullNameNode = gNode.SelectSingleNode($"text[@class='{classForFullName}']");
            if (fullNameNode != null)
            {
                result.FullName = fullNameNode.InnerText;
                result.Title = GetValidSibling(fullNameNode, classForRightSectionBlocks)?.InnerText;
                result.WorkingPlace = GetValidSibling(fullNameNode.NextSibling, classForRightSectionBlocks)?.InnerText;
            }

            var leftSectionNodes = gNode.SelectNodes($"text[@class='{classForLeftSectionBlocks}']");
            foreach (XmlNode sectionNode in leftSectionNodes)
            {
                if (sectionNode.InnerText == "Contact")
                {
                    ExtractContactData(sectionNode, result);
                }
                else if (sectionNode.InnerText == "Top Skills")
                {
                    ExtractTopSkillsData(sectionNode, result);
                }
            }

            var rightSectionNodes = gNode.SelectNodes($"text[@class='{classForRightSectionBlocks}']");
            foreach (XmlNode sectionNode in rightSectionNodes)
            {
                if (sectionNode.InnerText == "Experience")
                {
                    ExtractWorkingExperienceData(sectionNode, result);
                }
            }

            return result;
        }

        private void ExtractContactData(XmlNode xmlNode, Resume resume)
        {
            resume.Contact = new Contact();
            var baseNode = xmlNode;
            while (true)
            {
                var siblingNode = GetValidSibling(baseNode, classForLeftSectionBlocks);
                if (siblingNode != null)
                {
                    if (Regex.IsMatch(siblingNode.InnerText, "^(\\+[0-9])|^([0-9])$"))
                    {
                        resume.Contact.Phone = siblingNode.InnerText;
                    }
                    else if (Regex.IsMatch(siblingNode.InnerText, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
                    {
                        resume.Contact.Email = siblingNode.InnerText;
                    }
                    else if (Regex.IsMatch(siblingNode.InnerText, "^www.linkedin.com"))
                    {
                        resume.Contact.LinkedIn = siblingNode.InnerText;
                    }
                    baseNode = siblingNode;
                }
                else
                {
                    break;
                }
            }
        }

        private void ExtractTopSkillsData(XmlNode xmlNode, Resume resume)
        {
            var baseNode = xmlNode;
            while (true)
            {
                var siblingNode = GetValidSibling(baseNode, classForLeftSectionBlocks);
                if (siblingNode != null)
                {
                    resume.TopSkills = siblingNode.ChildNodes.OfType<XmlNode>().Select(x => x.InnerText).ToList();
                    baseNode = siblingNode;
                }
                else
                {
                    break;
                }
            }
        }

        private void ExtractWorkingExperienceData(XmlNode xmlNode, Resume resume)
        {
            resume.WorkingExperience = new WorkingExperience();

            classForOldCompany = xmlNode.NextSibling?.Attributes?["class"]?.Value;
            if (classForOldCompany != null)
            {
                var workingExperienceNodes = xmlNode.SelectNodes($"following-sibling::text[@class='{classForOldCompany}']");
                var gotLatestJob = false;
                foreach (XmlNode workingNode in workingExperienceNodes)
                {
                    if (!gotLatestJob)
                    {
                        resume.WorkingExperience = ExtractWorkingExperience(workingNode);
                    }
                    else
                    {
                        var other = ExtractWorkingExperience(workingNode);
                        resume.WorkingExperience.Others = string.Concat(
                            resume.WorkingExperience.Others == null ? string.Empty : string.Concat(resume.WorkingExperience.Others.Trim(), Environment.NewLine, "----------------", Environment.NewLine),
                            string.Join(Environment.NewLine, new string[] { other.Company, other.Title, other.Period, other.Description }).Trim()
                        ).Trim();

                    }
                    gotLatestJob = true;
                }
            }
        }

        private WorkingExperience ExtractWorkingExperience(XmlNode xmlNode)
        {
            var workingExperience = new WorkingExperience
            {
                Company = xmlNode.InnerText
            };
            var baseNode = xmlNode;
            var index = 1;

            while (true)
            {
                var siblingNode = GetValidSibling(baseNode, classForOldCompany);
                if (siblingNode != null)
                {
                    if (index == 1)
                    {
                        workingExperience.Title = siblingNode.InnerText;
                    }
                    else if (index == 2)
                    {
                        var nodes = siblingNode.ChildNodes.OfType<XmlNode>().ToList();
                        workingExperience.Period = string.Join(
                            " ", nodes.Take(2).Select(x => x.InnerText.Trim()));
                        workingExperience.Description = string.Join(
                            Environment.NewLine, nodes.Skip(2).Select(x => x.InnerText.Trim())
                        ).Trim();
                    }
                    else if (index == 4)
                    {
                        var nodes = siblingNode.ChildNodes.OfType<XmlNode>().ToList();
                        workingExperience.Description = string.Join(
                            Environment.NewLine, workingExperience.Description.Trim(),
                            string.Join(Environment.NewLine, nodes.Select(x => x.InnerText.Trim()))
                        ).Trim();
                    }
                    index++;
                    baseNode = siblingNode;
                }
                else
                {
                    break;
                }
            }

            return workingExperience;
        }
    }
}