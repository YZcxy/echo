using System;
using Newtonsoft.Json;
namespace echo_csharp
{
    public static class CreateMessage
    {
        public static String doCreate()
        {
            var info = new Info();
            info.ID=123;
            info.Detail="This is a message";
            info.Time=DateTime.Parse(DateTime.Now.ToString());

            var serializedResult = JsonConvert.SerializeObject(info);
            return serializedResult;
        }
    }
}