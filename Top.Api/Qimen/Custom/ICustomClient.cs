using System;
using System.Collections.Generic;
using System.Text;

namespace Top.Api.Qimen.Custom
{
    public interface ICustomClient
    {
        T Execute<T>(CustomRequest<T> request) where T : CustomResponse;
    }
}
