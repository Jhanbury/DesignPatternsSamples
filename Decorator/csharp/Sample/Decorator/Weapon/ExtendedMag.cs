using System;

namespace Decorator.Weapon
{
    public class ExtendedMag : WeaponAttachment
    {
        public ExtendedMag(IWeapon weapon) : base(weapon)
        {
        }
        public override void Fire()
        {
            _weapon.Fire();
            Console.WriteLine("     Extended Mag");

        }
    }
}