public class ExtendedMag extends WeaponAttachment {
    public ExtendedMag(IWeapon weapon) {
        super(weapon);
        this.name = "Extended Mag";
    }

    @Override
    public void Fire() {
        weapon.Fire();
        System.out.println("    " + this.name);
    }
}
