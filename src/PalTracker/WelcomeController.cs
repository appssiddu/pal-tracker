using Microsoft.AspNetCore.Mvc;

namespace PalTracker
{
    [Route("/")]
    public class WelcomeController : ControllerBase
    {
       
        private readonly WelcomeMessage _message;

        [HttpGet]
        public string SayHello() => _message.Message;

        public WelcomeController(WelcomeMessage  message)
        {
            _message = message;
        }
    }



     public class WelcomeMessage
    {
        public string Message { get; }

        public WelcomeMessage(string message)
        {
            Message = message;
        }
    }

      public class CloudFoundryInfo
    {
        public string Port { get; }
        public string MemoryLimit { get; }
        public string CfInstanceIndex { get; }
        public string CfInstanceAddr { get; }

        public CloudFoundryInfo(string port, string memoryLimit, string cfInstanceIndex, string cfInstanceAddr)
        {
            Port = port;
            MemoryLimit = memoryLimit;
            CfInstanceIndex = cfInstanceIndex;
            CfInstanceAddr = cfInstanceAddr;
        }
    }
}