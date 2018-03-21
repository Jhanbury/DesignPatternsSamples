public class Scope extends WeaponAttachment {
    public Scope(IWeapon weapon) {
        super(weapon);
        this.name = "Scope X8";
    }

    @Override
    public void Fire() {
        weapon.Fire();
        System.out.println("    " + this.name);
    }
}
