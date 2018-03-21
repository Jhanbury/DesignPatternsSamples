public class Main {

    public static void main(String[] args)
    {
        IWeapon weapon = new Gun("M4A1");

        WeaponAttachment scopedGun = new Scope(new ExtendedMag(weapon));

        scopedGun.Fire();
    }
}
