using System;

using Microsoft.Extensions.DependencyInjection;

using Amazon.Runtime;

using R5T.Dacia;

using R5T.D0057;


namespace R5T.D0059
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="AmazonSecurityTokenServiceProvider"/> implementation of <see cref="IAmazonSecurityTokenServiceProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAmazonSecurityTokenServiceProvider(this IServiceCollection services,
            IServiceAction<AWSCredentials> awsCredentialsAction,
            IServiceAction<IRegionEndpointProvider> awsRegionEndpointProviderAction)
        {
            services
                .AddSingleton<IAmazonSecurityTokenServiceProvider, AmazonSecurityTokenServiceProvider>()
                .Run(awsCredentialsAction)
                .Run(awsRegionEndpointProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AmazonSecurityTokenServiceProvider"/> implementation of <see cref="IAmazonSecurityTokenServiceProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAmazonSecurityTokenServiceProvider> AddAmazonSecurityTokenServiceProviderAction(this IServiceCollection services,
            IServiceAction<AWSCredentials> awsCredentialsAction,
            IServiceAction<IRegionEndpointProvider> regionEndpointProviderAction)
        {
            var serviceAction = ServiceAction.New<IAmazonSecurityTokenServiceProvider>(() => services.AddAmazonSecurityTokenServiceProvider(
                awsCredentialsAction,
                regionEndpointProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="AmazonSecurityTokenServiceOperator"/> implementation of <see cref="IAmazonSecurityTokenServiceOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddAmazonSecurityTokenServiceOperator(this IServiceCollection services)
        {
            services.AddSingleton<IAmazonSecurityTokenServiceOperator, AmazonSecurityTokenServiceOperator>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="AmazonSecurityTokenServiceOperator"/> implementation of <see cref="IAmazonSecurityTokenServiceOperator"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAmazonSecurityTokenServiceOperator> AddAmazonSecurityTokenServiceOperatorAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction.New<IAmazonSecurityTokenServiceOperator>(() => services.AddAmazonSecurityTokenServiceOperator());
            return serviceAction;
        }
    }
}
