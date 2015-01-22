using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
    Vector2 position;
    float x, y;
    float nextSwitchTime;
    float attackDelay = 1f;
    public float speed = 5f;
    
    void FixedUpdate()
    {
        if (Time.time > nextSwitchTime) SwitchDirection();
        position = transform.position;
        position.x += x * speed * Time.deltaTime;
        position.y += y * speed * Time.deltaTime;

        transform.position = position;
    }

    void SwitchDirection()
    {
        x = Random.Range(-1, 2);
        y = Random.Range(-1, 2);
        nextSwitchTime = Time.time + attackDelay;
    }
}
