using ProjDPBuilder.Model;

namespace ProjDPBuilder.Builder.ConcretBuilder;

public class PlanetBuilder : IPlanetBuilder
{
    private Planet _planet = new();

    public void BuildName(string n)
    {
        _planet.Name = n;
    }
    public void BuildRadius(double r)
    {
        _planet.Radius = r;
    }

    public void BuildMass(double m)
    {
        _planet.Mass = m;
    }

    public void BuildOrbitSpeed(double s)
    {
        _planet.OrbitSpeed = s;
    }

    public Planet GetPlanet()
    {
        return _planet;
    }
}