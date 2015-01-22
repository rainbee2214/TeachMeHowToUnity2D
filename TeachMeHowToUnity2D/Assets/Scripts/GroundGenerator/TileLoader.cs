using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TileLoader : MonoBehaviour
{
    List<GameObject> grassTiles;
    List<GameObject> dirtTiles;
    List<GameObject> waterTiles;

    int numberOfGrassTiles = 9;
    int numberOfDirtTiles = 9;
    int numberOfWaterTiles = 9;

    void Awake()
    {
        GetGrassTiles();
        //Sprites and GameObjects aren't ready yet
        GetDirtTiles();
        //GetWaterTiles();
    }

    void GetGrassTiles()
    {
        grassTiles = new List<GameObject>();
        for (int i = 1; i <= numberOfGrassTiles; i++)
        {
            grassTiles.Add(Resources.Load("Prefabs/Grass/Grass"+i, typeof(GameObject)) as GameObject);
        }
    }

    void GetDirtTiles()
    {
        dirtTiles = new List<GameObject>();
        for (int i = 1; i <= numberOfDirtTiles; i++)
        {
            dirtTiles.Add(Resources.Load("Prefabs/Dirt/Dirt" + i, typeof(GameObject)) as GameObject);
        }
    }

    void GetWaterTiles()
    {
        waterTiles = new List<GameObject>();
        for (int i = 1; i <= numberOfWaterTiles; i++)
        {
            waterTiles.Add(Resources.Load("Prefabs/Water/Water" + i, typeof(GameObject)) as GameObject);
        }
    }

    public GameObject GetRandomGrassTile()
    {
        return Instantiate(grassTiles[Random.Range(0, grassTiles.Count)]) as GameObject;
    }
    public GameObject GetRandomGrassTile(float x, float y)
    {
        return Instantiate(grassTiles[Random.Range(0, grassTiles.Count)], new Vector3(x,y, 1f), Quaternion.identity) as GameObject;
    }

    public GameObject GetRandomDirtTile()
    {
        return Instantiate(dirtTiles[Random.Range(0, dirtTiles.Count)]) as GameObject;
    }
    public GameObject GetRandomDirtTile(float x, float y)
    {
        return Instantiate(dirtTiles[Random.Range(0, dirtTiles.Count)], new Vector3(x, y, 1f), Quaternion.identity) as GameObject;
    }

    public GameObject GetRandomWaterTile()
    {
        return Instantiate(waterTiles[Random.Range(0, waterTiles.Count)]) as GameObject;
    }
    public GameObject GetRandomWaterTile(float x, float y)
    {
        return Instantiate(waterTiles[Random.Range(0, waterTiles.Count)], new Vector3(x, y, 1f), Quaternion.identity) as GameObject;
    }
}
