using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    float speed = 20f;
    Rigidbody2D rb;
    Vector3 clickPosition;

    Vector3 moveDirection;
    private void Awake()
    {
       rb = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        moveDirection = (Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position);
        moveDirection.z = 0;
        moveDirection.Normalize();


    }

    // Update is called once per frame
    void Update()
    {

        transform.position = transform.position + moveDirection * speed * Time.deltaTime;

        if (transform.position.x > 7 || transform.position.y > Input.mousePosition.y+4)
        {
            Destroy(this.gameObject);
        }

    }
}
