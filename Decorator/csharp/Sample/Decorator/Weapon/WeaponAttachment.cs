namespace Decorator.Weapon
{
    public abstract class WeaponAttachment : IWeapon
    {
        protected IWeapon _weapon;

        protected WeaponAttachment(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public virtual void Fire()
        {
            _weapon.Fire();
        }

        public string Name { get; }
    }

}