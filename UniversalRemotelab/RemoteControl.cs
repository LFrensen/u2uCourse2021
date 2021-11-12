using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalRemotelab
{
    public class RemoteControl
    {
        public IReceiver Receiver { get; set; }

        public void One()
        {
            Receiver.Channel = 1;
            Receiver.Play();
        }
        public void Two()
        {
            Receiver.Channel = 2;
            Receiver.Play();
        }
        public void Three()
        {
            Receiver.Channel = 3;
            Receiver.Play();
        }

    }
}
