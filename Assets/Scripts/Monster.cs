using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Monster : MonoBehaviour
{
    public int curHealth = 0;
    public int maxHealth = 100;
    public float speed = 0.2f;
    public Rigidbody2D monster;
    public Animator anim;
    public GameObject healthbar;
    public GameObject bullet;
    public GameObject lives;


    public AudioSource ow;
    public HealthBar healthBar;
    public LogicScript logic;
    public Animator endAnim;

    private Vector3 dir = Vector3.left;
    void Start()
    {
        curHealth = maxHealth;
    }

    private void Update()
    {
        move();
        if (curHealth <= 0)
        {
            healthbar.SetActive(false);
            bullet.SetActive(false);
            lives.SetActive(false);
            endAnim.SetBool("moveOn", true);
        }
        //transform.position = new Vector3(Random.Range(-2, 4), transform.position.y, transform.position.z);
        //monster.velocity = transform.position * speed;
    }

    public void DamagePlayer(int damage)
    {
        curHealth -= damage;

        healthBar.SetHealth(curHealth);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        //monster.velocity = Vector2.down * 0;
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            DamagePlayer(5);
            anim.SetTrigger("hit");
            ow.Play();
        }

    }

    public void move()
    {
        transform.Translate(dir * speed * Time.deltaTime);
        if(transform.position.x < -3.7)
        {
            dir = Vector3.right;
        }
        else if(transform.position.x > 5)
        {
            dir = Vector3.left;
        }
        
    }
}
