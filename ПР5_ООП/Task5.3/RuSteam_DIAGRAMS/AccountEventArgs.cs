using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuSteam_DIAGRAMS
{
    public class AccountEventArgs
    {
        public string Message { get; }
        public AccountEventArgs(string message)
        {
            Message = message;
        }
    }
}
