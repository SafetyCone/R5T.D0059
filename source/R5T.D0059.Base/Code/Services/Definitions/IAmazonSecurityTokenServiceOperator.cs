using System;
using System.Threading.Tasks;

using Amazon.SecurityToken;


namespace R5T.D0059
{
    public interface IAmazonSecurityTokenServiceOperator
    {
        Task<CallerIdentity> GetCallerIdentity(IAmazonSecurityTokenService sts);
    }
}
