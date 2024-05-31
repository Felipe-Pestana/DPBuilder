namespace ProjDPBuilder.Model;

public class Planet
{
    public string Name { get; set; } = String.Empty;
    public double Radius { get; set; }
    public double Mass { get; set; }
    public double OrbitSpeed { get; set; }

    public string ShowPlanet()
    {
        return $"Name: {this.Name}\n" +
               $"Radius: {this.Radius}km\n" +
               $"Mass: {this.Mass} x10\xB2\u2074" +
               $"\nOrbital Speed: {this.OrbitSpeed}km/s\n";
    }
}