public class Gun implements IWeapon {
    private String _name;

    public Gun(String _name) {
        this._name = _name;
    }

    @Override
    public void Fire() {
        System.out.println(this._name + " fired a round, Attachments:");
    }

    @Override
    public String GetName() {
        return this._name;
    }

    @Override
    public void SetName(String name) {
        this._name = name;
    }
}
