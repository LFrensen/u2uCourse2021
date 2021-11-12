using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversalRemotelab
{
    public class DVDPlayer : IReceiver
    {
        public int Channel { get; set; }

        public void Play()
        {
            Console.WriteLine($"You are connected to the DVDPlayer to the channel {Channel}");
        }
    }
}
