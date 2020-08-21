using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorchangingButton : MonoBehaviour
{
    bool buttonpressed = false;
    public bool chtogreen;
    public bool chtoblue;
    public GameObject obj;


    void OnTriggerEnter2D(Collider2D col)
    {

        buttonpressed = true;

    }

    void OnTriggerExit2D(Collider2D col)
    {
        buttonpressed = false;
       
    }

    void isbuttonpressed()
    {
        if (buttonpressed)
        {
            if (chtogreen)
            {
                togreen();
            }
            if (chtoblue)
            {
                toblue();
            }
        }
        else 
        {
            revertcolor();
        }
    }

    void togreen()
    {
        obj.layer = 9;
    }

    void toblue()
    {
        obj.layer = 9;
    }

    void revertcolor()
    {
        obj.layer = 12;
    }

}
