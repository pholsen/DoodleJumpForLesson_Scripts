using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumController : MonoBehaviour
{

    Rigidbody2D rb;
    Vector3 LastPosition;
    Vector3 CurrentPosition;

    public AudioClip saw;

    public GameObject bullet;
    public Transform firePoint;



    public bool isUp = false;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = saw;

    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isUp == true)
        {
            
            if (collision.gameObject.tag == "Ground")
            {
                isUp = false;
                GetComponent<AudioSource>().Play();
                rb.velocity = new Vector3(0, 10.5f, 0);

                

               

            }
            if (collision.gameObject.tag == "BlueGround")
            {
                isUp = false;
                GetComponent<AudioSource>().Play();
                rb.velocity = new Vector3(0, 21f, 0);

               
            }
        }
        if (collision.gameObject.tag=="Destroyer")
        {
            SceneManager.LoadScene(0);
            gameObject.SetActive(false);
        }
        
        
    }
    
    private void Update()
    {
        CurrentPosition = transform.position;
        if (CurrentPosition.y-LastPosition.y > 0)
        {
            isUp = false;
            GetComponent<BoxCollider2D>().enabled = false;
        }
        else if (CurrentPosition.y - LastPosition.y < 0)
        {
            isUp = true;
            GetComponent<BoxCollider2D>().enabled = true;
        }
        

        LastPosition = transform.position;

        if (this.transform.position.x >3.75f)
        {
            transform.Translate(-6.65f, 0,0);
        }
        if (this.transform.position.x <- 3.75f)
        {
            transform.Translate(6.65f, 0,0);
        }


        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }

        ////////////////////////////////////
        ///
        Vector3 charecterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            charecterScale.x = -0.1396234f;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            charecterScale.x = 0.1396234f;
        }
        transform.localScale = charecterScale;



        this.transform.Translate(Input.GetAxis("Horizontal")*Time.deltaTime*10, 0, 0);

        
    }
    void Shoot()
    {

        Instantiate(bullet, firePoint.position, firePoint.rotation);
    }
    private void Start()
    {
        LastPosition = transform.position;
    }

}
        
