using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicScript : MonoBehaviour
{
    public int lives = 3;
    public GameObject[] catLives;
    public GameObject cat;
    // Start is called before the first frame update
    void Start()
    {
        catLives = new GameObject[lives];
        for(int i = 0; i < lives; i++)
        {
            GameObject life = Instantiate(cat, new Vector3(transform.position.x, transform.position.y, 0), transform.rotation);
            catLives[i] = life;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void loseLife()
    {
        lives--;
        if (lives >= 0) { 
        Destroy(catLives[lives].gameObject);
        }
        else
        {
            gameOver();
        }

    }

    public void gameOver()
    {
        
        Debug.Log("hiiiii");
    }
}
