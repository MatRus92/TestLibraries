namespace MediatR
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            // Register MediatR services
            services.AddMediatR(typeof(Startup));

            // Way-2
            //services.AddMediatR(Assembly.GetExecutingAssembly());

            // Register MediatR services from multiple assembly.
            //services.AddMediatR(Assembly.GetExecutingAssembly(), typeof(ICustomerService).Assembly);
        }
    }
}
