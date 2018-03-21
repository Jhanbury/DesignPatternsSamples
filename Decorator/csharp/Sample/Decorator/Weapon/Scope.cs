using System;

namespace Decorator.Weapon
{
    public class Scope  : WeaponAttachment
    {
        public Scope(IWeapon weapon) : base(weapon)
        {
        }

        public override void Fire()
        {
            _weapon.Fire();
            Console.WriteLine("     Scope x4");
        }

        
    }
}