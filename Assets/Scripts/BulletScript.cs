using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float deadZone = -5.5f;
    public Monster monster;
    // Start is called before the first frame update
    void Start()
    {
        monster = GameObject.FindGameObjectWithTag("Monster").GetComponent<Monster>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < deadZone)
        {

            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D (Collision2D collision)
    {

        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.name == "Girl")
        {
            Physics2D.IgnoreCollision(collision.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());


        }
        else if (collision.gameObject.name != "Bullet(Clone)") 
        {
            Destroy(gameObject);
        }
        //monster.DamagePlayer(5);
    }

}
