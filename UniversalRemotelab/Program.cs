using System;

namespace UniversalRemotelab
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            CDPlayer cd = new CDPlayer();
            DVDPlayer dvd = new DVDPlayer();
            RemoteControl rc = new RemoteControl();
            rc.Receiver = cd;
            rc.One();

            rc.Receiver = dvd;
            rc.Three();

            rc.Receiver = tv;
            rc.Two();
        }
    }
}
