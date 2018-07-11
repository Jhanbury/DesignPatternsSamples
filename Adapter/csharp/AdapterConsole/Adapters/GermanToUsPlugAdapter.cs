using AdapterConsole.Plugs;
namespace AdapterConsole.Adapters
{
    public class GermanToUsPlugAdapter : IUsPlug
    {
        private readonly IGermanPlug _plug;

        public GermanToUsPlugAdapter(IGermanPlug plug)
        {
            _plug = plug;
        }
        public void ProvideElectricity()
        {
            _plug.GiveElectricity();
        }
    }
}