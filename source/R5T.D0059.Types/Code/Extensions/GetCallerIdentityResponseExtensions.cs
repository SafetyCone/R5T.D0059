using System;

using R5T.D0059;


namespace Amazon.SecurityToken.Model
{
    public static class GetCallerIdentityResponseExtensions
    {
        public static CallerIdentity GetCallerIdentity(this GetCallerIdentityResponse response)
        {
            var output = new CallerIdentity
            {
                Account = response.Account,
                ARN = response.Arn,
                UserID = response.UserId,
            };

            return output;
        }
    }
}
