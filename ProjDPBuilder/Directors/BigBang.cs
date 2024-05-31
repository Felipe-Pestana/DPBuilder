using ProjDPBuilder.Builder;
using ProjDPBuilder.Model;
namespace ProjDPBuilder.Directors;

public class BigBang
{
    private IPlanetBuilder _planetBuilder;

    public BigBang(IPlanetBuilder planetBuilder)
    {
        _planetBuilder = planetBuilder;
    }

    public Planet BigBangBoom(string n, double r, double m, double s)
    {
        _planetBuilder.BuildName(n);
        _planetBuilder.BuildRadius(r);
        _planetBuilder.BuildMass(m);
        _planetBuilder.BuildOrbitSpeed(s);

        return _planetBuilder.GetPlanet();
    }
}