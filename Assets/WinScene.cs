using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class WinScene : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public GameObject DialogueDisplay;
    public GameObject Light;
    public GameObject Girl;
    public catscript cat;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource;
    public Animator girlAnim;
    private bool allowSpace = true;
    private float speed = 5.5f;
    private bool moveNow = false;
    // initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        //Girl.SetActive(true);
        Light.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(false);
        //cat run away animation true;
        GameObject.FindGameObjectWithTag("Music").GetComponent<MusicClass>().PlayMusic();
        GameObject.FindGameObjectWithTag("ScaryMusic").GetComponent<ScaryMusic>().StopMusic();
    }

    void Update()
    {         // use spacebar as Next button
        if (moveNow == true)
        {
            move();
        }
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }
        }
        if (cat.cat == true)
        {
            cat.cat = false;
            Next();

        }
    }

    //Story Units! The main story function. Players hit [NEXT] to progress to the next primeInt:
    public void Next()
    {
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            DialogueDisplay.SetActive(true);
            nextButton.SetActive(true);
            Char1name.text = "Me";
            Char1speech.text = "I guess I won't be needing you anymore";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            DialogueDisplay.SetActive(false);
            Light.SetActive(true);
            nextButton.SetActive(false);
            girlAnim.SetBool("noLight", true);
            moveNow = true;
        }
        
        //Please do NOT delete this final bracket that ends the Next() function:
    }

    public void move()
    {
        if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                Girl.GetComponent<Rigidbody2D>().velocity = Vector2.down * speed;
                girlAnim.SetBool("Walking", true);
            }
            else if (Input.GetKeyUp(KeyCode.DownArrow))
            {
                Girl.GetComponent<Rigidbody2D>().velocity = Vector2.down * 0;
                girlAnim.SetBool("Walking", false);
            }
        if (Girl.transform.position.y <= -5.5f)
        {
            SceneManager.LoadScene("Conclusion");
        }



    }




}
