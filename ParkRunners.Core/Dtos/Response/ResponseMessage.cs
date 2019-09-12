using System;
using System.Collections.Generic;
using System.Text;

namespace ParkRunners.Core.Dtos.Response
{
    public abstract class ResponseMessage
    {
        public bool Success { get; }
        public string Message { get; }

        protected ResponseMessage(bool success = false, string message = null)
        {
            Success = success;
            Message = message;
        }

    }
}
