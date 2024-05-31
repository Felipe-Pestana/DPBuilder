using ProjDPBuilder.Builder.ConcretBuilder;
using ProjDPBuilder.Directors;

Console.OutputEncoding = System.Text.Encoding.Unicode;

Console.Clear();

Console.WriteLine("Hello, Nothing!");
Thread.Sleep(1000);
Console.WriteLine("\u00af\\(ツ)/\u00af");
Console.WriteLine("Let's Start Build Something...");
Thread.Sleep(2000);

var planetBuilder = new PlanetBuilder();
Console.WriteLine("ExpLoading...\n");
var bigBang = new BigBang(planetBuilder);
Thread.Sleep(1000);

var Mercury = bigBang.BigBangBoom("Mercury",4879.4,3.3011,47.36);
Console.WriteLine(Mercury.ShowPlanet());
Thread.Sleep(1000);

var Venus = bigBang.BigBangBoom("Venus",6051.8,4867.5,35.02);
Console.WriteLine(Venus.ShowPlanet());
Thread.Sleep(1000);

var Earth = bigBang.BigBangBoom("Earth",6371,5972.168,29.7827);
Console.WriteLine(Earth.ShowPlanet());
Thread.Sleep(1000);

var Mars = bigBang.BigBangBoom("Mars",3389.5,6.4171,24.07);
Console.WriteLine(Mars.ShowPlanet());
Thread.Sleep(1000);

var Jupiter = bigBang.BigBangBoom("Jupiter",69.911,1.8982,13.07);
Console.WriteLine(Jupiter.ShowPlanet());
Thread.Sleep(1000);

var Saturn = bigBang.BigBangBoom("Saturn",58.232,5.6834,9.68);
Console.WriteLine(Saturn.ShowPlanet());
Thread.Sleep(1000);

var Uranus = bigBang.BigBangBoom("Uranus",25.362,8.6810,6.80);
Console.WriteLine(Uranus.ShowPlanet());
Thread.Sleep(1000);

var Neptune = bigBang.BigBangBoom("Neptune",24.622,1.02409,5.43);
Console.WriteLine(Neptune.ShowPlanet());
Thread.Sleep(1000);

var Pluto = bigBang.BigBangBoom("Pluto",1.188,1.3025,4.743);
Console.WriteLine(Pluto.ShowPlanet());
Thread.Sleep(1000);

Console.WriteLine("Hello, Solar System! Welcome to the Universe...");