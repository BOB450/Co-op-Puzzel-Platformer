using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorchangingButton : MonoBehaviour
{
    bool buttonpressed = false;
    public bool chtogreen;
    public bool chtoblue;
    public GameObject obj;
    public Material blue;
    public Material green;


    void OnTriggerEnter2D(Collider2D col)
    {

        buttonpressed = true;
        isbuttonpressed();

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
        Debug.Log("togren");

    }

    void toblue()
    {
        obj.layer = 12;
        Debug.Log("toblue");
    }

    void revertcolor()
    {
        if (chtogreen)
        {
            obj.layer = 12;
            blue.SetColor("_Color", Color.green);
        }
        if (chtoblue)
        {
            
            obj.layer = 9;
        }
    }

}
