using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Apps.WebApi.Core
{
    public class BaseApiController : ApiController
    {
        public ApiOperationContext OpeCur
        {
            get
            {
                return ApiOperationContext.Current;
            }
        }

    }
}
