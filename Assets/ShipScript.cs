using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public Rigidbody2D ship;
    public LogicScript logic;
    void Start()
    {
        
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
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) == true){
            ship.velocity = Vector2.right * speed;
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow)){
            ship.velocity = Vector2.left * 0;
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow)){
            ship.velocity = Vector2.right * 0;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        logic.loseLife();
    }
}
