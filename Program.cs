using System;
using DesafioPOO.Models;

Nokia nokia = new Nokia(phoneNumber: "03675543", phoneModel: "Nokia15", imei: "111111111111", memory: 64);
Iphone iphone = new Iphone(phoneNumber: "88547732", phoneModel: "Iphone12", imei: "22222222222", memory: 128);

Console.WriteLine("Smartphone: Nokia");
nokia.MakingACall();
nokia.InstallingApps("Whatsapp");
Console.WriteLine();
Console.WriteLine("Smartphone: Iphone");
iphone.ReceivingACall();
iphone.InstallingApps("Spotfy");

