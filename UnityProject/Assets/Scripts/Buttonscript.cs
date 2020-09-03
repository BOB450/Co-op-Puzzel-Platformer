using System.Collections;
using System.Collections.Generic;
//using System.Diagnostics;
using UnityEngine;



public class Buttonscript : MonoBehaviour
{

    bool buttonpressed = false;//is button pressed
    public Transform walldownpos;
    public Transform walluppos;
    public GameObject wall;
    public bool iswallhorozontal;
   






    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime);
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
           

            if (iswallhorozontal == false)
            {
                movedown();
                Debug.Log("yes");
            }
            if (iswallhorozontal == true)
            {
                movedownhor();
                Debug.Log("yeshor");
            }


        }
        else
        {
            Debug.Log("change color");
            if (iswallhorozontal == false)
            {
                moveup();
                Debug.Log("no");
            }
            if (iswallhorozontal == true)
            {
                moveuphor();
                Debug.Log("nohor");
            }
        }


    }



    void movedown()
    {
        while (walldownpos.position.y < wall.transform.position.y)
        {

            wall.transform.Translate(0, -Time.deltaTime, 0, Space.World);

        }
    }

    void moveup()
    {

        while (walluppos.position.y > wall.transform.position.y)
        {

            wall.transform.Translate(0, Time.deltaTime, 0, Space.World);

        }

    }


    void moveuphor() 
    {


        while (walluppos.position.x < wall.transform.position.x)
        {

            wall.transform.Translate(-Time.deltaTime, 0, 0, Space.World);

        }


    }

    void movedownhor()
    {
        while (walldownpos.position.x > wall.transform.position.x)
        {

            wall.transform.Translate(Time.deltaTime, 0, 0, Space.World);

        }
    }


}
    



