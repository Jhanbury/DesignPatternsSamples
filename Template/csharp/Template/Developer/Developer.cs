using System;

namespace Template.Developer
{
    public abstract class Developer
    {
        public void DailyRoutine()
        {
            WakeUp();
            Work();
            Relax();
        }

        public virtual void WakeUp()
        {
            Console.WriteLine("Wake Up");
        }
        public virtual void Work()
        {
            Console.WriteLine("Work");
        }

        public virtual void Relax()
        {
            Console.WriteLine("Relax");
        }
    }
}