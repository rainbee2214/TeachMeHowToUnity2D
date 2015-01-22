using UnityEngine;
using System.Collections;

public class CollisionTriggerExample : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag =="Cube") Debug.Log(other.tag +" trigger.");
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.tag + " collision.");
    }
}
