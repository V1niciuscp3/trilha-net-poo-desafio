using DesafioPOO.Models;

System.Console.WriteLine("Marca Iphone");
Iphone iphone = new Iphone("250","Iphone X","123456789",128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
iphone.ReceberLigacao();

System.Console.WriteLine("\n");

System.Console.WriteLine("Marca Nokia");
Nokia nokia = new Nokia("1","NOKIA 5.4","123456",64);
nokia.Ligar();
nokia.InstalarAplicativo("TikTok");
nokia.ReceberLigacao();

