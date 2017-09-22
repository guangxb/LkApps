using System;
using System.Collections.Generic;
using System.Text;

namespace CustomHttpClient
{
    public interface ICustomClient
    {
        T Execute<T>(CustomRequest<T> request) where T : CustomResponse;
    }
}
