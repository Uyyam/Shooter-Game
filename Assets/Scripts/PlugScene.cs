using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PlugScene : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public GameObject DialogueDisplay;
    //public GameObject scene0;
    //public GameObject scene12;
    //public GameObject scene13;
    //public GameObject scene14;
    //public GameObject scene15;
    //public GameObject scene16;
    //public GameObject scene17;
    //public GameObject scene18;
    public Animator anim;
    public GameObject NextSceneButton;
    public GameObject instructions;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    // initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(true);
        Char1name.text = "Me";
        Char1speech.text = "I guess I can't go any further";
        Char2name.text = ""; ;
        Char2speech.text = "";
        //scene0.SetActive(true);
        //scene12.SetActive(false);
        //scene13.SetActive(false);
        //scene14.SetActive(false);
        //scene15.SetActive(false);
        //scene16.SetActive(false);
        //scene17.SetActive(false);
        //scene18.SetActive(false);
        NextSceneButton.SetActive(false);
        //NextScene2Button.SetActive(false);
        instructions.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Next();
            }
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
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            anim.SetBool("start", true);
            StartCoroutine(DelayedSceneChange(1.9f));
        }
       
    }

    IEnumerator DelayedSceneChange(float delay)
    {
        yield return new WaitForSecondsRealtime(delay);
        instructions.SetActive(true);
        NextSceneButton.SetActive(true);
    }

    public void SceneChange()
    {
        SceneManager.LoadScene("Game");
    }

}
