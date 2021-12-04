using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public Text GameOverText;
    public GameObject cameraa;

    void Start()
    {

    }
    IEnumerator Reset()
    {
        
        GameOverText.enabled = true;

        yield return new WaitForSeconds(2);

        SceneManager.LoadScene(0);

        

        StartCoroutine("Reset");
    }


void Update()
    {

        if (cameraa.GetComponent<CameraScript>().isDead == true)
        {
          //  GameOverText.enabled = true;
            StartCoroutine("Reset");
          //  SceneManager.LoadScene(0);
        }
        else
        {
            GameOverText.enabled = false;
        }
    }
}
