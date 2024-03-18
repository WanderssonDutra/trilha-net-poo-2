using System;
using System.Runtime;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        
        public Smartphone(string phoneNumber, string phoneModel, string imei, int memory)
        {
            PhoneNumber = phoneNumber;
            PhoneModel = phoneModel;
            Imei = imei;
            Memory = memory;
        }
        public string PhoneNumber { get; set; }

        protected string PhoneModel { get; set; }

        protected string Imei { get; set; }

        protected int Memory { get; set; }

        public void MakingACall()
        {
            Console.WriteLine("Calling...");
        }
        public void ReceivingACall()
        {
            Console.WriteLine("Receiving a call...");
        }

        public abstract void InstallingApps(string app);
    }
}