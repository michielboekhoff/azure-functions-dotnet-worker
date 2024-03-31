namespace Microsoft.Extensions.DependencyInjection
{
    internal static class TestService
    {
        public static IServiceCollection AddTestWorker(this IServiceCollection services)
        {
            return services;
        }
    }
}
