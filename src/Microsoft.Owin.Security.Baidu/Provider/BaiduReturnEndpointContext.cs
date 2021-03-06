// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

using Microsoft.Owin.Security.Provider;

namespace Microsoft.Owin.Security.Baidu
{
    /// <summary>
    /// Provides context information to middleware providers.
    /// </summary>
    public class BaiduReturnEndpointContext : ReturnEndpointContext
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="context">OWIN environment</param>
        /// <param name="ticket">The authentication ticket</param>
        public BaiduReturnEndpointContext(
            IOwinContext context,
            AuthenticationTicket ticket)
            : base(context, ticket)
        {
        }
    }
}