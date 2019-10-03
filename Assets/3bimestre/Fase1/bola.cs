using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    [SerializeField] private GameObject bolaa;

    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    Vector2 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    //    if(Input.GetMouseButtonDown(0) && mouse.y >= 3.2)
    //    {
    //      
    //    }

    //}

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector2 mousepo = new Vector2(ray.origin.x, ray.origin.y);
            RaycastHit2D hit = Physics2D.Raycast(mousepo, Vector2.zero);

            if(hit.collider != null && hit.collider.gameObject.tag == "click")
            {
                Instantiate(bolaa, Vector3.Scale(ray.origin,Vector3.one - Vector3.forward), Quaternion.identity);
            }
        }
       


    }
}
