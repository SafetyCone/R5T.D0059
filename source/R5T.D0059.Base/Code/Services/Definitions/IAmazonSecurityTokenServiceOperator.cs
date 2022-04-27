using System;
using System.Threading.Tasks;

using Amazon.SecurityToken;

using R5T.T0064;


namespace R5T.D0059
{
    [ServiceDefinitionMarker]
    public interface IAmazonSecurityTokenServiceOperator : IServiceDefinition
    {
        Task<CallerIdentity> GetCallerIdentity(IAmazonSecurityTokenService sts);
    }
}
