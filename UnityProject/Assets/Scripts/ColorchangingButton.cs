using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorchangingButton : MonoBehaviour
{
    bool buttonpressed = false;
    public bool chtogreen;
    public bool chtoblue;
    public bool chtopurple;
    public GameObject obj;
    SpriteRenderer sprite;
    public string objcolor;

    void Start()
    {
        sprite = obj.GetComponent<SpriteRenderer>();
    }


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
            if (chtopurple)
            {
                topurple();
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
        sprite.color = new Color(0, 1, 0, 1);

    }

    void toblue()
    {
        obj.layer = 12;
        Debug.Log("toblue");
        sprite.color = new Color(0, 0, 1, 1);
    }

    void topurple()
    {
        obj.layer = 8;
        Debug.Log("toblue");
        sprite.color = new Color(1, 0, 1, 1);
    }

    void revertcolor()
    {
        if (objcolor == "purple")
        {
            obj.layer = 8;
            sprite.color = new Color(1, 0, 1, 1);
        }
        if (objcolor == "blue")
        {
            sprite.color = new Color(0, 0, 1, 1);
            obj.layer = 12;
        }
        if (objcolor == "green")
        {
            sprite.color = new Color(0, 1, 0, 1);
            obj.layer = 9;
        }
    }

}
