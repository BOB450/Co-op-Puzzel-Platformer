using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingplatform : MonoBehaviour
{

    public GameObject rightpos;
    public GameObject leftpos;
    public GameObject plat;
    private Rigidbody2D rb;
    public bool movingright = true;
    float platx;
    float leftx;
    float rightx;
    public float speed;
    public float cordright;
    public float cordleft;

    void Start()
    {
        Debug.Log(plat.transform.position.x);
        rb = GetComponent<Rigidbody2D>();

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        platx = plat.transform.position.x;
        rightx = rightpos.transform.position.x;
        leftx = leftpos.transform.position.x;
        if (movingright == true)
        {
            //  plat.transform.Translate(Vector3.Lerp.right * Time.deltaTime);
            rb.velocity = new Vector3(speed, 0, 0);
        }
        if (movingright == false)
        {
            // plat.transform.Translate(Vector3.right * -Time.deltaTime);
            rb.velocity = new Vector3(-speed, 0, 0);
        }
        if (platx >= cordright )
        {
            movingright = false;
        }
        if (platx <= cordleft)
        {
            movingright = true;
        }
        
    }


}
