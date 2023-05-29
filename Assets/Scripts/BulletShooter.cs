using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public Rigidbody2D gravity;
    public LogicScript logic;
    public BulletBar ammo;
    public AudioSource pew;
    public int curAmmo = 0;
    public int maxAmmo = 100;
    public float bulletSpeed = 3;
    // Start is called before the first frame update
    void Start()
    {
        curAmmo = maxAmmo;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            GameObject newBullet = Instantiate(bullet, new Vector3(spawnPoint.position.x, spawnPoint.position.y, 0), transform.rotation);
            curAmmo -= 1;
            ammo.SetHealth(curAmmo);
            pew.Play();


        }
        if(curAmmo == 0)
        {
            logic.gameOver();
        }
    }
}
