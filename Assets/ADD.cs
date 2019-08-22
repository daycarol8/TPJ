using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADD : MonoBehaviour
{
    Touch touch;
    Vector2 vector2;
    [SerializeField] private GameObject obj;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
#if UNITY_ANDROID
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            vector2 = Camera.main.ScreenToWorldPoint(touch.position);
            Instantiate(obj, vector2, Quaternion.identity);
        }
    }
#elif UNITY_STANDALONE || UNITY_EDITOR
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            Vector2 mousepo = new Vector2(ray.origin.x, ray.origin.y);
            RaycastHit2D hit = Physics2D.Raycast(mousepo, Vector2.zero);
            Instantiate(obj, Vector3.Scale(ray.origin, Vector3.one - Vector3.forward), Quaternion.identity);
        }
#endif
    }
}
