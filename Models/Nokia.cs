using System;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
       public Nokia (string phoneNumber, string phoneModel, string imei, int memory) : base(phoneNumber, phoneModel, imei, memory)
       {

       }

        public override void InstallingApps(string app)
        {
            Console.WriteLine($"Installing {app} in your Nokia.");
        }
    }
}