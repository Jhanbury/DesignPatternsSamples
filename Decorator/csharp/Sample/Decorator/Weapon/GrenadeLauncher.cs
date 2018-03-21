using System;

namespace Decorator.Weapon
{
    public class GrenadeLauncher : WeaponAttachment
    {
        public GrenadeLauncher(IWeapon weapon) : base(weapon)
        {
        }

        public override void Fire()
        {
            _weapon.Fire();
            Console.WriteLine("     Grenade Launcher");
        }
    }
}