using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlatformScript : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime);

        if (transform.localPosition.x >= 3f)
        {
            dirRight = false;
        }

        if (transform.localPosition.x <= -3)
        {
            dirRight = true;
        }
    }
}
