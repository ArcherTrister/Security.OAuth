﻿/*
 * Licensed under the Apache License, Version 2.0 (http://www.apache.org/licenses/LICENSE-2.0)
 * See https://github.com/ArcherTrister/LeXun.Security.OAuth
 * for more information concerning the license and the contributors participating to this project.
 */

namespace Microsoft.AspNetCore.Security.Authentication.Csdn
{
    /// <summary>
    /// Contains constants specific to the <see cref="CsdnAuthenticationHandler"/>.
    /// </summary>
    public static class CsdnAuthenticationConstants
    {
        public static class Claims
        {
            ///// <summary>
            ///// 当前登录用户的数字ID
            ///// </summary>
            //public const string UserId = "urn:csdn:userid";
            ///// <summary>
            ///// 当前登录用户的用户名，值可能为空。
            ///// </summary>
            //public const string UserName = "urn:csdn:username";
            /// <summary>
            /// 城市
            /// </summary>
            public const string City = "urn:csdn:city";
            /// <summary>
            /// 行业
            /// </summary>
            public const string Industry = "urn:csdn:industry";
            /// <summary>
            /// 工作
            /// </summary>
            public const string Job = "urn:csdn:job";
            /// <summary>
            /// 工作年限
            /// </summary>
            public const string WorkYear = "urn:csdn:workyear";
            /// <summary>
            /// 网站
            /// </summary>
            public const string Website = "urn:csdn:website";
            /// <summary>
            /// 个人简介
            /// </summary>
            public const string Description = "urn:csdn:description";
            ///// <summary>
            ///// 性别
            ///// </summary>
            //public const string Gender = "urn:csdn:gender";

        }
    }
}
