using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using KataStringCalculator.Validators;


namespace KataStringCalculator.IOC
{
    public class Container
    {
        public static T GetService<T>()
          => CreateHostBuilder().Services.GetService<T>();


        private static IHost CreateHostBuilder() =>
           Host
               .CreateDefaultBuilder()
               .ConfigureServices((_, services) =>
                   services
                       .AddSingleton<ICalculator, Sum>()
                       .AddSingleton<IValidator>(_ =>
                       {
                           var NumberLimitvalidator = new NumberLimitValidator();
                           NumberLimitvalidator.SetNext(new NotNegativeValidator());
                           return NumberLimitvalidator;
                       }
                       )
               ).Build();
    }
}
