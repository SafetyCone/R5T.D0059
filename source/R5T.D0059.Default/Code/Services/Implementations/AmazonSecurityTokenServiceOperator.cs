using System;
using System.Threading.Tasks;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;

using R5T.T0064;


namespace R5T.D0059
{
    [ServiceImplementationMarker]
    public class AmazonSecurityTokenServiceOperator : IAmazonSecurityTokenServiceOperator, IServiceImplementation
    {
        public async Task<CallerIdentity> GetCallerIdentity(IAmazonSecurityTokenService sts)
        {
            var request = new GetCallerIdentityRequest();

            var response = await sts.GetCallerIdentityAsync(request);

            var output = response.GetCallerIdentity();
            return output;
        }
    }
}
