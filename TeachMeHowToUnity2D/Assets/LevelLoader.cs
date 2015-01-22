using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour
{
    public string level = "Menu";
    public float delay = 5f;

    void Start()
    {
        delay += Time.time;
    }

    void Update()
    {
        if (Time.time > delay) Application.LoadLevel(level);
    }
}
