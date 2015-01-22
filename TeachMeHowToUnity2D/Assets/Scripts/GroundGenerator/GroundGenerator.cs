using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(TileLoader))]
public class GroundGenerator : MonoBehaviour
{
    public int width = 9;
    public int height = 9;
    TileLoader tiles;
    List<GameObject> grassTiles;
    List<GameObject> boundaries;

    void Start()
    {
        tiles = GetComponent<TileLoader>();
        DrawGrass();
    }
   
    void DrawGrass()
    {
        grassTiles = new List<GameObject>();
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                grassTiles.Add(tiles.GetRandomGrassTile(x*3, y*3));
                grassTiles[grassTiles.Count-1].transform.parent = transform;
            }
        }
    }

}
