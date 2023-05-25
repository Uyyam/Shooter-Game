using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public Rigidbody2D gravity;
    public float bulletSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject newBullet = Instantiate(bullet, new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0), transform.rotation);
            //newBullet.GetComponent<Rigidbody2D>().velocity = spawnPoint.up * bulletSpeed;

        }
    }
}
