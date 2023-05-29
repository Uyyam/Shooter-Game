using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1 : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public GameObject DialogueDisplay;
    public GameObject scene11;
    public GameObject scene12;
    public GameObject scene13;
    public GameObject scene14;
    public GameObject scene15;
    public GameObject scene16;
    public GameObject scene17;
    public GameObject scene18;
    public GameObject NextSceneButton;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    // initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        DialogueDisplay.SetActive(false);
        scene11.SetActive(true);
        scene12.SetActive(false);
        scene13.SetActive(false);
        scene14.SetActive(false);
        scene15.SetActive(false);
        scene16.SetActive(false);
        scene17.SetActive(false);
        scene18.SetActive(false);
        NextSceneButton.SetActive(false);
        //NextScene2Button.SetActive(false);
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
            DialogueDisplay.SetActive(true);
            Char1name.text = "Me";
            Char1speech.text = "Not here...";
            Char2name.text = ""; ;
            Char2speech.text = "";
}
        else if (primeInt == 3)
        {
            scene12.SetActive(true);
            Char1speech.text = "Not under here…";
        }
        else if (primeInt == 4)
        {
            Char1speech.text = "Oh! I know where he is…!";
        }
        else if (primeInt == 5)
        {
            scene13.SetActive(true);
            Char1speech.text = "He must be here!";

        }
        else if (primeInt == 6)
        {
            scene14.SetActive(true);
            Char1speech.text = "Hmmhmmmm…";
        }
        else if (primeInt == 7)
        {
            scene15.SetActive(true);
            Char1speech.text = "...";

        }
        else if (primeInt == 8)
        {
            Char1speech.text = "He isn’t…";
        }
        else if (primeInt == 9)
        {
            Char1speech.text = "Sir Prince Duke Lawrence Stuffingtons III, where are you?";
        }
        else if (primeInt == 10)
        {
            scene16.SetActive(true);
            Char1speech.text = "Oh no…";
        }
        else if (primeInt == 11)
        {
            Char1speech.text = "He must've been...";
        }
        else if (primeInt == 12)
        {
            scene17.SetActive(true);
            Char1speech.text = "Captured..!";
        }
        else if (primeInt == 13)
        {
            scene18.SetActive(true);
            Char1speech.text = "Please, no… I don’t wanna go there…";
        }
        else if (primeInt == 14)
        {
            Char1speech.text = "But...";
        }
        else if (primeInt == 15)
        {
            scene15.SetActive(false);
            scene16.SetActive(false);
            scene17.SetActive(false);
            scene18.SetActive(false);
            scene14.SetActive(true);
            Char1speech.text = "It’s okay. I have my nightlight!";
            NextSceneButton.SetActive(true);
            nextButton.SetActive(false);
        }
        //Please do NOT delete this final bracket that ends the Next() function:
    }


    public void SceneChange()
    {
        SceneManager.LoadScene("Hallway Walk");
    }

}