using System.Net.Http;
using Interview.Web.Weather;
using SimpleInjector;

namespace Interview.Web.DependencyInjection
{
    public class DiConfig
    {
        public Container Container { get; private set; }

        public DiConfig()
        {
            Container = new Container();
            Container.Options.ResolveUnregisteredConcreteTypes = false;
        }

        public void Register()
        {
            Container.Register<IWeatherDataService, WeatherDataService>();
            Container.Register<IWeatherAnalyticsService, WeatherAnalyticsService>();
        }

        public void Verify() => Container.Verify();
    }
}