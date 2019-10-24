using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moviment : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Animator anim;
    private bool idle;
    private bool andar;
    public SpriteRenderer sprite;

    private void Update()
    {
        anim.SetBool("idle", idle);
        anim.SetBool("andar", andar);

        Move();
        if (Input.GetAxis("Horizontal") > 0)
        {
            idle = false;
            andar = true;
            sprite.flipX = false;
        }
        else if (Input.GetAxis("Horizontal") < 0)
        {
            idle = false;
            andar = true;
            sprite.flipX = true;
        }

        if (Input.GetAxis("Horizontal") == 0)
        {
            idle = true;
            andar = false;
            
        }
    }
    void Move()
    {
        rb.velocity = new Vector3(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0);
    }


}
