using System;

namespace dotnetservice.Models
{
    public class PongMessage
    {
        public string Message { get; }
        public DateTime Timestamp { get; }

        public PongMessage(string message)
        {
            Message = message;
            Timestamp = DateTime.Now;
        }
    }
}