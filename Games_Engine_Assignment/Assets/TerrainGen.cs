/*

This is the terrain generation script which generates the terrain procedurally and then moves the offset of the terrain to make
it seem as though the player is moving all while staying still.

*/

using UnityEngine;

public class TerrainGen : MonoBehaviour
{
    // Declaration of all ints and floats to be used
    public int placeholder;

    public int terrain_depth = 10;
    public int terrain_width = 256;
    public int terrain_height = 256;
    public float terrain_scale = 15f;
    public float terrain_offset_x = 10f;
    public float terrain_offset_y = 10f;

    // Variable to be used to allow for generation only once and then to only change the offset after
    public int sets = 0;

    void Update()
    {
        // Call to the function to generate terrain offset and then take in the data of said terrain from generation function
        GenerateOffset();
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
    }

    // Function to generate offset of the terrain
    void GenerateOffset()
    {
        if (sets == 0)
        {
            // Generation of the offset
            terrain_offset_x = Random.Range(0f, 250f);
            terrain_offset_y = Random.Range(0f, 250f);
            sets++;
        }
        else
        {
            // Changing the offset just slightly
            terrain_offset_x = terrain_offset_x - 0.020f;
        }
    }

    //Function to generate the terrain randomly and a call to another function which will generate the heights
    TerrainData GenerateTerrain(TerrainData data)
    {
        data.heightmapResolution = terrain_width + 1;
        data.size = new Vector3(terrain_width, terrain_depth, terrain_height);
        data.SetHeights(0, 0, GenerateHeights());
        return data;
    }

    // Function to return heights as an array
    float[,] GenerateHeights()
    {
        float[,] heights = new float[terrain_width, terrain_height];
        for (int x = 0; x < terrain_width; x++)
        {
            for (int y = 0; y < terrain_height; y++)
            {
                heights[x, y] = CalculateHeights(x, y);
            }
        }
        return heights;
    }

    // Below function calculates the heights through offset and scale that are assigned
    float CalculateHeights(int x, int y)
    {
        float xCoordinate = ((float)x / terrain_width) * terrain_scale + terrain_offset_x;
        float yCoordinate = ((float)y / terrain_height) * terrain_scale + terrain_offset_y;
        return Mathf.PerlinNoise(xCoordinate, yCoordinate);
    }
}