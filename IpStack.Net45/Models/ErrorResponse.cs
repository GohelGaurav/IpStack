using System;
using System.Collections.Generic;
using System.Text;

namespace IpStack.Net45.Models
{
    public class ErrorResponse
    {
        public bool Success { get; set; } = true;

        public Error Error { get; set; }
    }
}
