using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverLab
{
    public class RemoteControl
    {
        public TV Tv { get; set; }

        public void One()
        {
            Tv.Channel = 1;
            Tv.Play();
        }
        public void Two()
        {
            Tv.Channel = 2;
            Tv.Play();
        }
        public void Three()
        {
            Tv.Channel = 3;
            Tv.Play();
        }

    }
}
