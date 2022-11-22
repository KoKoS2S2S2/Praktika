using booking.Infrastructure.Reposytory.Implementations;
using booking.Infrastructure.Reposytory.Interfacies;

namespace booking
{
    public static class DependencyInjection
    {
        public static void RegisterDependesy(this IServiceCollection service)
        {
            service.AddTransient<IHotelRepository, HotelRepository>();
        }
    }
}
