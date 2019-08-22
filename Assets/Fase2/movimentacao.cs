using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacao : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bola;
    float move;
    [SerializeField] private float speed;
    [SerializeField] private float forcapulo;
    
    void Start()
    {
        //forcapulo = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            bola.AddForce(Vector2.up * forcapulo);
            
        }
    }

    private void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        bola.velocity = new Vector2(move * speed, 0);
    }

}
