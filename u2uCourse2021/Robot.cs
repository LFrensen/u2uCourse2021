using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u2uCourse2021
{
    public delegate void Routine(Robot r);
    public delegate void RobotEventHandler(object sender, EventArgs eventArgs);
    public class Robot
    {
        public string Name { get; set; }
        public Point Position { get; set; }
        public Routine Routine { get; set; } // delegate instance
        public event RobotEventHandler Stepped; //event -> lightningbolt (events are delegates, only difference is the event keyword)
        protected virtual void OnStepped(EventArgs eventArgs)
        {
            this.Stepped(this, eventArgs);
        }
        
        public void MoveTo(int x, int y)
        {
            Position = new Point(x, y);
            OnStepped(null);
        }
        public void Go()
        {
            Console.WriteLine($"{Name} IS ABOUT TO START");
            this.Routine(this);
        }
    }
}
