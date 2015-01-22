using UnityEngine;
using System.Collections;

public class PlayerPhysics : MonoBehaviour
{
    Vector2 position;
    public float speed = 1f;

    Vector2 currentDirection = -Vector2.up;
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy") GameController.controller.Health = -1;
    }

    public void Attack()
    {
        if (currentDirection == Vector2.up)
        {
            anim.SetTrigger("AttackBack");
        }
        else if (currentDirection == -Vector2.up)
        {
            anim.SetTrigger("AttackForward");
        }
        else if (currentDirection == Vector2.right)
        {
            anim.SetTrigger("AttackRight");
        }
        else if(currentDirection == -Vector2.right)
        {
            anim.SetTrigger("AttackLeft");
        }
    }

    public void Move()
    {
        if (Input.GetAxisRaw("Vertical") > 0)
        {
            anim.SetBool("IsWalkingBack", true);
            anim.SetBool("IsWalkingForward", false);
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false);
            currentDirection = Vector2.up;
        }
        else if (Input.GetAxisRaw("Vertical") < 0)
        {
            currentDirection = -Vector2.up;
            anim.SetBool("IsWalkingBack", false);
            anim.SetBool("IsWalkingForward", true);
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false);
        }
        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            currentDirection = Vector2.right;
            anim.SetBool("IsWalkingBack", false);
            anim.SetBool("IsWalkingForward", false);
            anim.SetBool("IsWalkingRight", true);
            anim.SetBool("IsWalkingLeft", false);
        }
        else if (Input.GetAxisRaw("Horizontal") < 0)
        {
            currentDirection = -Vector2.right;
            anim.SetBool("IsWalkingBack", false);
            anim.SetBool("IsWalkingForward", false);
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", true);
        }
        else
        {
            anim.SetBool("IsWalkingBack", false);
            anim.SetBool("IsWalkingForward", false);
            anim.SetBool("IsWalkingRight", false);
            anim.SetBool("IsWalkingLeft", false);
        }
  

        position = transform.position;

        position.x += Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime;
        position.y += Input.GetAxisRaw("Vertical") * speed * Time.deltaTime;
        
        transform.position = position;
    }
}
