using System;
using System.Threading.Tasks;

using Amazon.SecurityToken;


namespace R5T.D0059
{
    public interface IAmazonSecurityTokenServiceProvider
    {
        Task<IAmazonSecurityTokenService> GetAmazonSecurityTokenService();
    }
}
