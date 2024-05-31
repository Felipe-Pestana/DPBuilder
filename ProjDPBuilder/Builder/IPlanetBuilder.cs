using ProjDPBuilder.Model;

namespace ProjDPBuilder.Builder;

public interface IPlanetBuilder
{
    void BuildName(string n);
    void BuildRadius(double r);
    
    void BuildMass(double m);
    
    void BuildOrbitSpeed(double s);

    Planet GetPlanet();
}