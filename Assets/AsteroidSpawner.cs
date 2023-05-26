using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{

    public GameObject asteroid;
    public float spawnRate = 4;
    public float timer = 0;
    public int asteroidCounter = 0;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(
            asteroid,
            new Vector3(0, transform.position.y, 0),
            transform.rotation);
        asteroidCounter++;
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnAsteroid();
            timer = 0;
            if (spawnRate > 0.9)
            {
                 spawnRate -= 0.4f;
                // 
 
            }
            else if(asteroidCounter % 10 == 0 && spawnRate >= 0.2)
            {
                spawnRate -= 0.1f;
            }
        }

    }

    void spawnAsteroid(){
        Instantiate(
            asteroid,
            new Vector3(Random.Range(-5, 5), transform.position.y, 0),
            transform.rotation);
        asteroidCounter++;

    }

}
