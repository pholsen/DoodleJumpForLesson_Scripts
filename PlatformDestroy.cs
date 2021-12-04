using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDestroy : MonoBehaviour
{
   public GameObject destroyer;
    void Start()
    {
        destroyer = GameObject.FindGameObjectWithTag("Destroyer");
    }
    
   
    // Update is called once per frame
    void Update()
    {
        if (destroyer.transform.position.y - 3> gameObject.transform.position.y)
        {
            Destroy(this.gameObject);
        }
    }
}
