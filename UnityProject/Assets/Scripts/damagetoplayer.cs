using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class damagetoplayer : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "greenPlayer")
        {
            SceneManager.LoadScene(2);
        }
        if (col.gameObject.tag == "bluePlayer")
        {
            SceneManager.LoadScene(2);
        }


    }
}
