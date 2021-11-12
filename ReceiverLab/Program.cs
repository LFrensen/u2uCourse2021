using System;

namespace ReceiverLab
{
    class Program
    {
        static void Main(string[] args)
        {
            TV tv = new TV();
            RemoteControl rc = new RemoteControl();
            rc.Tv = tv;

            rc.One();
            rc.Two();
            rc.Three();

        }
    }
}
