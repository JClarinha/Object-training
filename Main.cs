/*Computer c1 = new Computer("yellow", "MacOs");

System.Console.WriteLine(c1.GetColor() + "\n" + c1.GetOS() );

c1.SetColor("black");
System.Console.WriteLine(c1.GetColor()); */

using System.Security.Cryptography;

Computer c2 = new Computer();
System.Console.WriteLine("What brand is your Computer?");
string brand = System.Console.ReadLine();
System.Console.WriteLine("Now tell me the color of it");
string cor = System.Console.ReadLine();
System.Console.WriteLine("Hummm, that's great. \n Now tell me the rest... HA... Ha... Ha...");
System.Console.WriteLine("Cpu??  ;)");
string Cpu = System.Console.ReadLine();
System.Console.WriteLine("Gpu?? ;) ;)");
string Gpu = System.Console.ReadLine();
System.Console.WriteLine("Ram??? ;) ;) ;)");
int Ram = int.Parse(System.Console.ReadLine());
System.Console.WriteLine("Operating System ... ;) ... ;) ... ;)");
string Os = System.Console.ReadLine();

if (Os != "Linux")
{
    System.Console.WriteLine("You little bitch \nHacking in progress...");
}





c2.SetColor(cor);
c2.SetGPU(Gpu);
c2.SetCPU(Cpu);
c2.SetOS(Os);
c2.SetRAM(Ram);
c2.SetBrand(brand);

string Color = c2.GetColor();
string GPU = c2.GetGPU();
string CPU = c2.GetCPU();
string OS = c2.GetOS();
int RAM = c2.GetRAM();
string Brand = c2.GetBrand();

//System.Console.WriteLine(Color + "\n" + GPU + "\n" + CPU + "\n" + OS + "\n" + RAM + "\n" + Brand);
System.Console.WriteLine(c2.ToString());





