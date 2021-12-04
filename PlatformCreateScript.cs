using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreateScript : MonoBehaviour
{
    public GameObject[] platforms;

    public GameObject player;

    public int x = 1;

    


    
    void Start()
    {

        for (float i = 0; i < 120; i += 1.5f)
        {
            Instantiate(platforms[Random.Range(0,platforms.Length)], new Vector3(Random.Range(-3, 3), i, 0), Quaternion.identity);

        }
        
       /* for (float i = 200; i < 500; i += 1.5f)
        {
            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3(Random.Range(-3, 3), i, 0), Quaternion.identity);
        }
        for (float i = 500; i < 750; i += 2f)
        {
            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3(Random.Range(-3, 3), i, 0), Quaternion.identity);
        }
        for (float i = 750; i < 1000; i += 2.5f)
        {
            Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3(Random.Range(-3, 3), i, 0), Quaternion.identity);
        }*/

    }

    
    void Update()
    {
        Vector2 Characther = player.transform.position;
        if (Characther.y >= 100 * x)
        {
            Debug.Log(x);
            for (float i = 0; i < 120 * x; i += 1.5f)
            {
                Characther = player.transform.position;
                Instantiate(platforms[Random.Range(0, platforms.Length)], new Vector3(Random.Range(-3, 3), i*x + (100+(20*x)), 0), Quaternion.identity);
                Debug.Log(50);
            }
            
            x++;
            
        }
        
    }
}
