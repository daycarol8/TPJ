using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class movimentacao : MonoBehaviour
{
    [SerializeField] private Rigidbody2D bola;
    float move;
    [SerializeField] private float speed;
    [SerializeField] private float forcapulo;
    [SerializeField] private Text pontuacao;
    [SerializeField] private Canvas canvas;
    private int pont;
    
    void Start()
    {
        //forcapulo = 1000;
        //pont = 0;
        pont = PlayerPrefs.GetInt("Score");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            bola.AddForce(Vector2.up * forcapulo);
            
        }
        pontuacao.text = "Pontuação: " + pont;
        PlayerPrefs.SetInt("Score", pont);


    }

    private void FixedUpdate()
    {
        move = Input.GetAxis("Horizontal");
        bola.velocity = new Vector2(move * speed, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("pont"))
        {
            pont++;
            Destroy(collision.gameObject);
        }
        else if(collision.CompareTag("Portal"))
        {
            SceneManager.LoadScene("4At1");
            DontDestroyOnLoad(this.gameObject);
            DontDestroyOnLoad(canvas);
        }
    }

}
