using System;

namespace Decorator.Weapon
{
    public class Gun : IWeapon
    {
        public Gun(string weaponName)
        {
            Name = weaponName;
        }
        public void Fire()
        {
            Console.WriteLine($"{Name} fired a round, Attachments:");
        }

        public string Name { get; }
    }
}