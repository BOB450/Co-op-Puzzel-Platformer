using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Movingplatform : MonoBehaviour
{
    public Transform target;
    public Rigidbody2D rb;
    public float speed;
    public bool moveUp;
    private Transform startPos;
    public GameObject plat;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // moveplat();
    }



    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime;
        if (plat.transform.position.x == target.position.x)
        {
            moveUp = false;
        }
        else if (plat.transform.position.x == startPos.position.x)
        {
            moveUp = true;
        }
        if (moveUp == false)
        {
            rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime);
        }
        else if (moveUp)
        {
            rb.MovePosition(transform.position + transform.right * -Time.fixedDeltaTime);
        }
    }


}
