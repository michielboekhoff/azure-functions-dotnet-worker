using Microsoft.Azure.Functions.Worker;

namespace Microsoft.Extensions.DependencyInjection
{

    internal static class TestWorkerApplicationBuilderExtensions
    {
        public static IFunctionsWorkerApplicationBuilder UseTestWorker(this IFunctionsWorkerApplicationBuilder builder)
        {
            builder.Services.AddTestWorker();

            return builder;
        }
    }
}