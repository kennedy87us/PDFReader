namespace PdfReader.Model
{
    using System.Collections.Generic;

    public class Resume
    {
        public string FullName { get; set; }

        public string Title { get; set; }

        public string Company { get; set; }

        public string WorkingPlace { get; set; }

        public Contact Contact { get; set; }

        public List<string> TopSkills { get; set; }

        public WorkingExperience WorkingExperience { get; set; }
    }
}