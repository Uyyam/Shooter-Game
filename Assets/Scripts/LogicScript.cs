using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public int lives = 3;
    //public GameObject[] playerLives;
    public GameObject batteries;
    public GameObject end;
    public Text lifeCount;
    public cameraShake cam;
    //public AudioSource loser;

    //private float[,] coordinates = new float[,] { { -8, 4 }, { -7, 4 }, { -6, 4 } };
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
        end.SetActive(false);
        //playerLives = new GameObject[lives];
        //for(int i = 0; i < lives; i++)
        //{
        //    //GameObject life = Instantiate(batteries, new Vector3(coordinates[i, 0], coordinates[i, 1], 0), transform.rotation);
        //    playerLives[i] = life;
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loseLife()
    {
        lives--;
        lifeCount.text = lives.ToString();
        //if (lives >= 0) { 
        ////Destroy(playerLives[lives].gameObject);
        //}
        if (lives < 0)
        {
            gameOver();
        }

    }

    public void gameOver()
    {
        end.SetActive(true);
        Time.timeScale = 0.0f;
        cam.Shake(0, 0);
        //loser.Play();
    }
}
