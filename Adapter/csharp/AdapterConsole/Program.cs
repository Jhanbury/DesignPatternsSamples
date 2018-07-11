using System;
using AdapterConsole.Plugs;
using AdapterConsole.Adapters;
using AdapterConsole.Sockets;

namespace AdapterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            IGermanPlug plugConnector = new GermanPlug();
            UsSocket usElectricalSocket = new UsSocket();
            IUsPlug usAdapter = new GermanToUsPlugAdapter(plugConnector);
            usElectricalSocket.plugIn(usAdapter);
                    
        }
    }
}
