using System.ComponentModel.Design;
using SixLabors.ImageSharp.PixelFormats;

namespace RealWorldBiomeMapCreator.Biomes;

public static class BiomeMapper
{
    // @TODO implementeer dit
    public static Biome DetermineBiome(Rgba32 color, int height)
    {
        // Voorbeeldlogica om kleuren aan biomes te koppelen
        
        // cold biomes 
        if (color.R > 200 && color.G > 200 && color.B > 200)
        {
            return Biome.SNOWY_PLAINS;
        }
        
        else if (color.R > 150 && color.G > 220 && color.B > 220)
        {
            return Biome.FROZEN_RIVER;
        }
        
        else if (color.R < 50 && color.G > 100 && color.B < 100)
        {
            return Biome.TAIGA;
        }
        
        else if (color.R > 240 && color.G > 240 && color.B > 200)
        {
            return Biome.SNOWY_BEACH;
        }
        
        else if (color.R > 100 && color.G > 100 && color.B > 100 && color.R < 200 && color.G < 200 && color.B < 200)
        {
            return Biome.WINDSWEPT_HILLS;
        }
        
        else if (color.R > 100 && color.G > 150 && color.B > 100)
        {
            return Biome.WINDSWEPT_FOREST;
        }


        
        // medium temp biomes 
        
        else if (color.R > 120 && color.G > 180 && color.B < 80)
        {
            return Biome.PLAINS;
        }
        
        
        else if (color.R < 100 && color.G > 150 && color.B< 100)
        {
            return Biome.FOREST;
        }
        
        else if (color.R > 180 && color.G > 230 && color.B > 180)
        {
            return Biome.BIRCH_FOREST;
        }
        
        else if (color.R < 50 && color.G < 80 && color.B < 50)
        {
            return Biome.DARK_FOREST;
        }
        
        else if (color.R > 240 && color.G > 220 && color.B > 150)
        {
            return Biome.BEACH;
        }
        
        
        else if (color.R < 50 && color.G > 100 && color.B < 50)
        {
            return Biome.SWAMP;

        }
        
        else if (color.R < 50 && color.G < 50 && color.B > 120)
        {
            return Biome.RIVER;
        }
        
        // (sub)tropical biomes
        
        
        else if (color.R > 150 && color.G > 100 && color.B < 50)
        {
            return Biome.SAVANNA; 
        }
        
        else if (color.R < 100 && color.G > 180 && color.B < 100)
        {
            return Biome.JUNGLE;
        }
        
        else if (color.R > 100 && color.G > 150 && color.B > 100)
        {
            return Biome.SPARSE_JUNGLE;
        }

        
        else if (color.R < 100 && color.G > 120 && color.B > 100)
        {
            return Biome.MANGROVE_SWAMP;
        }
        
        else if (color.R > 240 && color.G > 220 && color.B < 100)
        {
            return Biome.DESERT;
        }
        
        else if (color.R > 180 && color.G < 100 && color.B < 80)
        {
            return Biome.BADLANDS;
        }
        
        



        
        
         
        
        
        
        //oceans
        
        else if (color.R < 50 && color.G < 50 && color.B > 200)
        {
            return Biome.OCEAN;
        }
 
        if (color.R < 20 && color.G < 20 && color.B > 80)
        {
            return Biome.DEEP_OCEAN;
            
        }
        
        else if (color.R > 150 && color.G > 200 && color.B > 200)
        {
            return Biome.FROZEN_OCEAN;
        }
        
        else if (color.R < 100 && color.G < 100 && color.B > 150)
        {
            return Biome.COLD_OCEAN;
        }
        
        
        
        else if (color.R < 100 && color.G > 120 && color.B > 120)
        {
            return Biome.LUKEWARM_OCEAN;
        }
        
        
        else if (color.R < 50 && color.G > 150 && color.B > 150)
        {
            return Biome.WARM_OCEAN;
        }
        
       
        
        


        
        
        
        
        
        else if (color.R > 200 && color.G > 150 && color.B < 50)
        {
            return Biome.DESERT;
        }

        
      

            
        else
        {
            return Biome.PLAINS;
        }

       
     }
}
