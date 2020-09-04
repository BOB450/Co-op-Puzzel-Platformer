using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camrafollow : MonoBehaviour
{
    public Transform blueplayer;
    public Transform greenplayer;
    public Vector3 offset;
    public bool camonblue = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (camonblue == true)//switch to blue
        {
            transform.position = new Vector3(blueplayer.position.x + offset.x, blueplayer.position.y + offset.y, offset.z);
        }
        if (camonblue == false)//switch to green
        {
            transform.position = new Vector3(greenplayer.position.x + offset.x, greenplayer.position.y + offset.y, offset.z);
        }
        checkinput();
    }
    void checkinput() 
    {
        if (Input.GetButtonDown("camswi"))
        {
           // Debug.Log("swibutton down");
            if (camonblue == true)
            {
                camonblue = false;
                Debug.Log(camonblue);
                return;
            }
            if(camonblue == false)
            {
                camonblue = true;
                Debug.Log(camonblue);
                return;
            }
        }
    }
}
