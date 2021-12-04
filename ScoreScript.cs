using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Text scoreText;
    public Rigidbody2D rb;
   public  GameObject player;
    public float topScore = 0.0f;
    public float enemyScore;

    void Update()
    {


        if (player.transform.position.y > topScore)
        {
            topScore = player.transform.position.y;
        }
        scoreText.text = "score= " + (Mathf.Round(topScore+enemyScore).ToString());
    }
}
