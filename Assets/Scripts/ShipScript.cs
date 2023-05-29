using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 5;
    public Rigidbody2D girl;
    public LogicScript logic;
    public Animator anim;
    public cameraShake cam;
    public AudioSource ouch;
    private Vector2 movement = Vector2.zero;
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
            girl.velocity =Vector2.left * speed;
            anim.SetBool("walkLeft", true);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow) == true){
            girl.velocity = Vector2.right * speed;
            anim.SetBool("walkRight", true);
        }
        else if(Input.GetKeyUp(KeyCode.LeftArrow)){
            girl.velocity = Vector2.left * 0;
            anim.SetBool("walkLeft", false);
        }
        else if(Input.GetKeyUp(KeyCode.RightArrow)){
            girl.velocity = Vector2.right * 0;
            anim.SetBool("walkRight", false);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        StartCoroutine(cam.Shake(0.03f, 1f));
        logic.loseLife();
        ouch.Play();
    }
}
