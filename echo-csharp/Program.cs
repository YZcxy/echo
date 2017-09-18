using System;
using Apache.NMS;
using Apache.NMS.Stomp;

namespace echo_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var messages = 3;
            while (messages-- > 0)
            {
                Producer.proHandler();
                Publish.pubHandler();   
            }

        }
    }
}
