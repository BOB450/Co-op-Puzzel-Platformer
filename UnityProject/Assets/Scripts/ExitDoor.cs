using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour
{
    public string nextscene;
     bool greenplayer = false;
     bool blueplayer = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (blueplayer == true && greenplayer == true)
        {
            MoveTonextsene();
        }
    }
    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "greenPlayer")
        {
            greenplayer = true;
        }

        if (col.gameObject.tag == "bluePlayer")
        {
           blueplayer = true;
        }


    }

    void MoveTonextsene() {

        SceneManager.LoadScene(nextscene, LoadSceneMode.Single);

    }

}
