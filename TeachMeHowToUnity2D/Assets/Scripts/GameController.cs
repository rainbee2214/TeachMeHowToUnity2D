using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static GameController controller;

    private int health = 10;
    public int Health
    {
        get { return health; }
        set { health += value; }
    }

    private bool dead = false;
    public bool Dead
    {
        get { return dead; }
        set { dead = value; }
    }

    void Awake()
    {
        if (controller == null)
        {
            DontDestroyOnLoad(gameObject);
            controller = this;
        }
        else if (controller != this)
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        controller = this;

    }

    void FixedUpdate()
    {
        if (health <= 0)
        {
            health = 0;
            dead = true;
        }
        if (dead) Debug.Log("The player died.");
    }
}
