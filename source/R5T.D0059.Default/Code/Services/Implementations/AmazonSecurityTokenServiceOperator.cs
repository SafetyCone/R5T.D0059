using System;
using System.Threading.Tasks;

using Amazon.SecurityToken;
using Amazon.SecurityToken.Model;


namespace R5T.D0059
{
    public class AmazonSecurityTokenServiceOperator : IAmazonSecurityTokenServiceOperator
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
