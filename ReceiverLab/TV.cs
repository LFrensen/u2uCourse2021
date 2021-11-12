using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverLab
{
    public class TV
    {
        public int Channel { get; set; }

        public void Play()
        {
            Console.WriteLine($"The TV is playing on channel: {Channel}");
        }
    }
}
