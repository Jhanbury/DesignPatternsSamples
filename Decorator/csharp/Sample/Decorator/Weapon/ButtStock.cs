using System;

namespace Decorator.Weapon
{
    public class ButtStock : WeaponAttachment
    {
        public ButtStock(IWeapon weapon) : base(weapon)
        {

        }

        public override void Fire()
        {
            _weapon.Fire();
            Console.WriteLine("     Butt Stock");
        }
    }
}