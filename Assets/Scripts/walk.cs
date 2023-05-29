using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class walk : MonoBehaviour
{
    public float speed = 5.5f;
    public float stop = -1.1f;
    public float duration = 0.0f;
    public float magnitude = 0.0f;
    public float timer = 0;
    public float elapsedTime = 0.02f;
    public float initialDifference;
    public bool change = false;
    public Rigidbody2D girl;
    public Animator anim;
    public cameraShake cam;
    public GameObject question;
    public GameObject wire;

    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
        question.SetActive(false);
        initialDifference = wire.transform.position.y - 0.39f - girl.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        var currentDifference = wire.transform.position.y - girl.transform.position.y;
        // Get the ratio between the initial and current positions
        var scaleFactor = currentDifference / (initialDifference + 0.2f);
        wire.transform.localScale = new Vector3(0.1f, scaleFactor, 1f);
        // Apply ratio to the Y axis of the object
        move();
        if (transform.position.y < stop)
        {
            screenShake();
            change = true;
        }
        if(change == true)
        {
            transition();
        }

    }

    public void move()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow) == true)
        {
            
            girl.velocity = Vector2.down * speed;
            anim.SetBool("GameDone", true);
            // Store the starting difference between the two positions on Y
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            girl.velocity = Vector2.down * 0;
            anim.SetBool("GameDone", false);
        }
        //else if (Input.GetKeyDown(KeyCode.LeftArrow) == true)
        //{
        //    girl.velocity = Vector2.left * speed;
        //    anim.SetBool("walkLeft", true);
        //}
        //else if (Input.GetKeyDown(KeyCode.RightArrow) == true)
        //{
        //    girl.velocity = Vector2.right * speed;
        //    anim.SetBool("walkRight", true);
        //}
        //else if (Input.GetKeyUp(KeyCode.LeftArrow))
        //{
        //    girl.velocity = Vector2.left * 0;
        //    anim.SetBool("walkLeft", false);
        //}
        //else if (Input.GetKeyUp(KeyCode.RightArrow))
        //{
        //    girl.velocity = Vector2.right * 0;
        //    anim.SetBool("walkRight", false);
        //}
    }

    public void screenShake()
    {

        girl.velocity = Vector2.down * 0;
        anim.SetBool("GameDone", false);
        StartCoroutine(cam.Shake(duration, magnitude));
        transform.position = new Vector3(transform.position.x, 0.7f, transform.position.z);

    }

    public void transition()
    {

        if (timer < elapsedTime)
        {
            timer += Time.deltaTime;
            Debug.Log(timer);
            if (timer >= 0.8f)
            {
                question.SetActive(true);
            }
        }
        else
        {
            SceneManager.LoadScene("Plug Scene");
        }
    }
}