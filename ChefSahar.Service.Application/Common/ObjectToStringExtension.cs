using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChefSahar.Service.Application.Common
{
    public static class ObjectToStringExtension
    {
        public static string ObjectToString(this object value)
        {
            return JsonConvert.SerializeObject(value);
        }
    }
}
