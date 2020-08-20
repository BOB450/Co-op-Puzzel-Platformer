using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;



public class Buttonscript : MonoBehaviour
{

    bool buttonpressed = false;//is button pressed
    public Transform walldownpos;
    public Transform walluppos;
    public GameObject bluewall;
    public bool iswallhorozontal;
   






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    // player colides with button
    void OnTriggerEnter2D(Collider2D col)
    {


        //if (myTrigger.gameObject.name == "Dana")
        //  {
        // Debug.Log("Entered");
        buttonpressed = true;
        isbuttonpressed();
        //}
    }
    void OnTriggerExit2D(Collider2D col)
    {
        buttonpressed = false;
        isbuttonpressed();
    }

    void isbuttonpressed()
    {
        if (buttonpressed)
        {
            Debug.Log("yes");

            // DestroyGameObject();
            movedown();


        }
        else
        {
            Debug.Log("change color");

            moveup();

        }


    }



    void movedown()
    {
        while (walldownpos.position.y < bluewall.transform.position.y)
        {

            bluewall.transform.Translate(0, -Time.deltaTime, 0, Space.World);

        }
    }

    void moveup()
    {

        while (walluppos.position.y > bluewall.transform.position.y)
        {

            bluewall.transform.Translate(0, Time.deltaTime, 0, Space.World);

        }

    }


}
    



