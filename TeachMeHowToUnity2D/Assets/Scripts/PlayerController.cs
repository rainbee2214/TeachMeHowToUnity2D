using UnityEngine;
using System.Collections;

[RequireComponent(typeof(PlayerPhysics))]
public class PlayerController : MonoBehaviour
{
    PlayerPhysics playerPhysics;

    void Start()
    {
        playerPhysics = gameObject.GetComponent<PlayerPhysics>();
    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump")) playerPhysics.Attack();
        playerPhysics.Move();
    }
}
