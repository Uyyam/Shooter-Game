using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidMover : MonoBehaviour
{
    //public float speed = 2;
    public LogicScript logic;
    public Rigidbody2D gravity;
    public GameObject crash;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += (Vector3.down * speed) * Time.deltaTime;
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // decrease life
        // show crash asset
        Debug.Log("destroy");
        Instantiate(crash, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, 0),transform.rotation);
        Destroy(gameObject);
    }

}
