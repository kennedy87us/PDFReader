namespace PdfReader.Ioc
{
    using Microsoft.Extensions.DependencyInjection;
    using PdfReader.Business.Contracts;
    using PdfReader.Business;

    public static class RegisterServices
    {
        public static void Register(IServiceCollection builderServices)
        {
            builderServices.AddScoped<IPdfParser, PdfParser>();
        }
    }
}