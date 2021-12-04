using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject player;
    public bool isDead;
    

    public float TopCameraLevel= 3f;


    Vector3 offset;
    

   
    void Update()
    {



        offset.y = player.transform.position.y - (transform.position.y);

        if (player.transform.position.y > transform.position.y )
        {   
            transform.position += new Vector3(0, offset.y, 0);
        }


        if (transform.position.y-player.transform.position.y > 6)
        {
            isDead = true;

        }
        
    }
}
