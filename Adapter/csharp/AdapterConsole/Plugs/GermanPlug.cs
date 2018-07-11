using System;
namespace AdapterConsole.Plugs
{
    public class GermanPlug : IGermanPlug
    {
        public void GiveElectricity(){
            Console.WriteLine("German plug electricity");
        }
    }
}