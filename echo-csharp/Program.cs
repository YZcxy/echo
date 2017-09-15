using System;
using Apache.NMS;
using Apache.NMS.Stomp;

namespace echo_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Publish.pubHandler();
        }
    }
} 
