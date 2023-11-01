namespace PdfReader.Business.Contracts
{
    using PdfReader.Model;

    public interface IPdfParser
    {
        Resume Deserialize(string pathFile);
    }
}