using Decorator.Weapon;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon gun = new Gun(" M4A1");

            var scopedGun = new GrenadeLauncher(new ButtStock(new ExtendedMag(new Scope(gun))));
           

            scopedGun.Fire();
        }
    }
}
