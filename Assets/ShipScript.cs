using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public Rigidbody2D ship;
    public LogicScript logic;
    public Animator anim;
    void Start()
    {
        anim.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        move();
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    public void move(){

        if (Input.GetKeyDown(KeyCode.LeftArrow) == true){
            ship.velocity = Vector2.left * speed ;
            anim.SetBool("isWalkingL", true);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) == true){
            ship.velocity = Vector2.right * speed;
            anim.SetBool("isWalkingR", true);
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow)){
            ship.velocity = Vector2.left * 0;
            anim.SetBool("isWalkingL", false);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow)){
            ship.velocity = Vector2.right * 0;
            anim.SetBool("isWalkingR", false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        logic.loseLife();
    }
}
