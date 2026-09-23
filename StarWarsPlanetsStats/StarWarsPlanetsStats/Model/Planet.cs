using StarWarsPlanetsStats.DTOs;
using StarWarsPlanetsStats.Extensions;

namespace StarWarsPlanetsStats.Model;

public readonly record struct Planet
{
    public readonly string? Name { get; }
    public readonly int? Diameter { get; }
    public readonly int? SurfaceWater { get; }
    public readonly int? Population { get; }

    public Planet(
        string? name,
        int? diameter,
        int? surfaceWater,
        int? population)
    {
        if (name is null)
        {
            throw new ArgumentNullException(nameof(name));
        }

        Name = name;
        Diameter = diameter;
        SurfaceWater = surfaceWater;
        Population = population;
    }

    public static explicit operator Planet(Result planetDTo)
    {
        string? name = planetDTo.name;
        int? diameter = planetDTo.diameter.ToIntOrNull();
        int? surfaceWater = planetDTo.surface_water.ToIntOrNull();
        int? population = planetDTo.population.ToIntOrNull();
        return new Planet(name, diameter, surfaceWater, population);
    }
}