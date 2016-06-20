using MvvmCross.Plugins.Messenger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldClock.Core.Services
{
    public class OffsetMessage : MvxMessage
    {
        public OffsetMessage(object sender,int offset) : base(sender)
        {
            Offset = offset;
        }

        public double Offset { get; private set; }
    }
}
