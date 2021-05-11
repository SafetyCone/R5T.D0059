using System;
using System.Threading.Tasks;

using Amazon.Runtime;
using Amazon.SecurityToken;

using R5T.D0057;


namespace R5T.D0059
{
    public class AmazonSecurityTokenServiceProvider : IAmazonSecurityTokenServiceProvider
    {
        private AWSCredentials AWSCredentials { get; }
        private IRegionEndpointProvider RegionEndpointProvider { get; }


        public AmazonSecurityTokenServiceProvider(
            AWSCredentials aWSCredentials,
            IRegionEndpointProvider regionEndpointProvider)
        {
            this.AWSCredentials = aWSCredentials;
            this.RegionEndpointProvider = regionEndpointProvider;
        }

        public async Task<IAmazonSecurityTokenService> GetAmazonSecurityTokenService()
        {
            var awsRegionEndpoint = await this.RegionEndpointProvider.GetRegionEndpoint();

            // Note, you might see an exception demanding an app.config/web.config.
            // This is just a result of stopping on exceptions you should not stop on. Disable stopping on the exception of type, and restart until this line succeeds.
            // And it is this constructor that's the problem: https://github.com/aws/aws-sdk-net/issues/1401
            // Also: https://forums.aws.amazon.com/thread.jspa?messageID=809937&tstart=0
            var sts = new AmazonSecurityTokenServiceClient(this.AWSCredentials, awsRegionEndpoint);
            return sts;
        }
    }
}
