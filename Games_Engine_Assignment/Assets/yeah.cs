﻿using UnityEngine;

public class yeah : MonoBehaviour
{

    // I have replaced some variables throughout the code with this 'placeholder' variable.
    // You will need to replace the 'placeholder' throughout the code with the correct variable.
    public int placeholder;

    public int terrain_depth = 10;
    public int terrain_width = 256;
    public int terrain_height = 256;
    public float terrain_scale = 15f;
    public float terrain_offset_x = 10f;
    public float terrain_offset_y = 10f;

    public int sets = 0;

    void Update()
    {
        GenerateOffset();
        Terrain terrain = GetComponent<Terrain>();
        terrain.terrainData = GenerateTerrain(terrain.terrainData);
        Debug.Log(terrain_offset_x);
    }

    void GenerateOffset()
    {
        if (sets == 0)
        {

            terrain_offset_x = Random.Range(0f, 250f);
            terrain_offset_y = Random.Range(0f, 250f);
            sets++;
        }
        else
        {
            terrain_offset_x = terrain_offset_x - 0.020f;
        }
    }

    TerrainData GenerateTerrain(TerrainData data)
    {
        data.heightmapResolution = terrain_width + 1;
        data.size = new Vector3(terrain_width, terrain_depth, terrain_height);  // The Vector3 takes in 3 integer values, but which values and in what order?
        data.SetHeights(0, 0, GenerateHeights());
        return data;
    }

    float[,] GenerateHeights()
    {
        float[,] heights = new float[terrain_width, terrain_height];
        for (int x = 0; x < terrain_width; x++) // What variable swaps with the placeholder here?
        {
            for (int y = 0; y < terrain_height; y++) // What variable swaps with the placeholder here?
            {
                heights[x, y] = CalculateHeights(x, y);
            }
        }
        return heights;
    }

    float CalculateHeights(int x, int y)
    {
        float xCoordinate = ((float)x / terrain_width) * terrain_scale + terrain_offset_x;
        float yCoordinate = ((float)y / terrain_height) * terrain_scale + terrain_offset_y;
        return Mathf.PerlinNoise(xCoordinate, yCoordinate);
    }
}

