using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puasemenu : MonoBehaviour
{
    public bool gameispuased = false;
    public GameObject UI;
    // Start is called before the first frame update
    void Start()
    {
        UI.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        checkinput();
    }
    

    void checkinput() 
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gameispuased)
            {
                resume();
            }
            else
            {
                pause();
            }
        }
    }

    void resume()
    {
    
        Time.timeScale = 1f;
        UI.SetActive(false);
        gameispuased = false;
    }
    void pause()
    {
        Time.timeScale = 0f;
        UI.SetActive(true);
        gameispuased = true;
    }


    public void exitbutton()//on click
    {
        Application.Quit();//quits application
        Debug.Log("kjsdnfkljsdf");

    }

    public void resumebutton()//on click
    {
        resume();

    }

}
