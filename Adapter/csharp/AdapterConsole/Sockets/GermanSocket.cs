using System;
using AdapterConsole.Plugs;
namespace AdapterConsole.Sockets
{
    public class GermanSocket
    {
        public void plugIn(IGermanPlug plug) 
        {
            Console.WriteLine("German Socket");
            plug.GiveElectricity();
        }
    }
}