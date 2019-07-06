using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Hosting;
using Microsoft.Extensions.ML;
using TitanicBuilderML.Model.DataModels;
using TitanicFunction;

[assembly: WebJobsStartup(typeof(Startup))]
namespace TitanicFunction
{
    class Startup : IWebJobsStartup
    {
        public void Configure(IWebJobsBuilder builder)
        {
            builder.Services.AddPredictionEnginePool<ModelInput, ModelOutput>()
                // .FromFile("Models/MLModel.zip");
                .FromUri("https://titanicfuncseo201907stor.blob.core.windows.net/models/MLModel.zip");
        }
    }
}