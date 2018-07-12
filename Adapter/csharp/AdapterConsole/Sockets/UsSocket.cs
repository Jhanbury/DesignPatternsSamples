using System;
using AdapterConsole.Plugs;
namespace AdapterConsole.Sockets
{
    public class UsSocket
    {
        public void plugIn(IUsPlug plug)
        {
            Console.WriteLine("US Socket");

            plug.ProvideElectricity();
        }
    }
}