using System.ComponentModel.Design;
using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Biomes;

public static class BiomeMapper
{
    // @TODO implementeer dit
    public static Biome DetermineBiome(Rgba32 color, int height)
    {
        // Voorbeeldlogica om kleuren aan biomes te koppelen
        if (color.R > 200 && color.G > 200 && color.B > 200)
        {
            return Biome.SNOWY_PLAINS;
        }

        if (color.R < 100 && color.G > 150 && color.B< 100)
        {
            return Biome.FOREST;
        }
        
        else if (color.R < 50 && color.G < 50 && color.B > 200)
        {
            return Biome.OCEAN;
        }

        if (color.R < 20 && color.G < 20 && color.B > 80)
        {
            return Biome.DEEP_OCEAN;
        }
        else if (color.R > 200 && color.G > 150 && color.B < 50)
        {
            return Biome.DESERT;
        }

        else if (color.R < 50 && color.G > 100 && color.B < 50)
        {
            return Biome.SWAMP;

        }
        else if (color.R > 150 && color.G > 100 && color.B < 50)
        {
            return Biome.SAVANNA; // Savannas: Light yellow-brown
        }

            
        else
        {
            return Biome.PLAINS;
        }

        if (color.R > 200 && color.G < 50 && color.B < 50)
        {
            
        }
     }
}
