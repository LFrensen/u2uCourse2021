using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalRemotelab
{
    public class TV : IReceiver
    {
        public int Channel { get; set; }

        public void Play()
        {
            Console.WriteLine($"You are connected to the TV to the channel {Channel}");
        }
    }
}
