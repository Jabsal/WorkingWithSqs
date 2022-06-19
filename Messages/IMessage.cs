using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumer.Messages
{
    public interface IMessage
    {
        public string MessageTypeName { get; }
    }
}
