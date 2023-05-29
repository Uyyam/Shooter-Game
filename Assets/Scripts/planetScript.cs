using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planetScript : MonoBehaviour
{
    public AudioSource hit;
    public LogicScript logic;
    public cameraShake cam;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        logic.loseLife();
        StartCoroutine(cam.Shake(0.03f, 1f));
        hit.Play();
    }
}
