using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public float deadZone = 5.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > deadZone)
        {

            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter2D (Collider2D collision)
    {
        Destroy(gameObject);
    }
}
