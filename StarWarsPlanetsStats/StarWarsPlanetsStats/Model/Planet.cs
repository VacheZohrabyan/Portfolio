using StarWarsPlanetsStats.DTOs;
using StarWarsPlanetsStats.Extensions;

namespace StarWarsPlanetsStats.Model;

public readonly record struct Planet
{
    public readonly string? Name { get; }
    public readonly long? Diameter { get; }
    public readonly long? SurfaceWater { get; }
    public readonly long? Population { get; }

    public Planet(
        string? name,
        long? diameter,
        long? surfaceWater,
        long? population)
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
        long? diameter = planetDTo.diameter.ToLongOrNull();
        long? surfaceWater = planetDTo.surface_water.ToLongOrNull();
        long? population = planetDTo.population.ToLongOrNull();
        return new Planet(name, diameter, surfaceWater, population);
    }
}