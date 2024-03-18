using System;


namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string phoneNumber, string phoneModel, string imei, int memory) : base(phoneModel, phoneModel, imei, memory)
        {

        }
        public override void InstallingApps(string app)
        {
            Console.WriteLine($"Installing {app} in your Iphone.");
        }
    }
}