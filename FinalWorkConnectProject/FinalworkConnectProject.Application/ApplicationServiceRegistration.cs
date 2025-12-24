namespace FinalWorkConnectProject.Application
{
    /// <summary>
    /// Registers application layer services and dependencies
    /// </summary>
    public static class ApplicationServiceRegistration
    {
        /// <summary>
        /// Adds application-level services to the dependency injection container
        /// </summary>
        /// <param name="services">Service collection</param>
        /// <returns>The updated service collection</returns>
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            // Registers AutoMapper profiles from the Application assembly
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            // Registers application services
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}