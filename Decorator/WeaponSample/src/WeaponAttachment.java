public class WeaponAttachment implements IWeapon {
    protected IWeapon weapon;
    protected String name;
    public WeaponAttachment(IWeapon weapon) {
        this.weapon = weapon;
    }

    @Override
    public void Fire() {
        weapon.Fire();
    }

    @Override
    public String GetName() {
        return this.name;
    }

    @Override
    public void SetName(String name) {
        this.name = name;
    }
}
