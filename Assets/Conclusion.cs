using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Conclusion : MonoBehaviour
{
    public int primeInt = 1;         // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public GameObject DialogueDisplay;
    public GameObject scene1;
    public GameObject scene2;
    public GameObject scene3;
    public GameObject scene4;
    public GameObject scene5;
    public GameObject scene6;
    public GameObject scene7;
    public GameObject thankyou;
    //public GameObject scene18;
    public GameObject NextSceneButton;
    //public GameObject NextScene2Button;
    public GameObject nextButton;
    public AudioSource click;
    private bool allowSpace = true;

    // initial visibility settings. Any new images or buttons need to also be SetActive(false);
    void Start()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "???"; ;
        Char2speech.text = "What are you doing...";
        DialogueDisplay.SetActive(true);
        scene1.SetActive(true);
        scene2.SetActive(false);
        scene3.SetActive(false);
        scene4.SetActive(false);
        scene5.SetActive(false);
        scene6.SetActive(false);
        scene7.SetActive(false);
        //scene18.SetActive(false);
        thankyou.SetActive(false);
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
            click.Play();
            scene2.SetActive(true);
            Char1name.text = "Me";
            Char1speech.text = "...";
            Char2name.text = ""; ;
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "Me";
            Char1speech.text = "Unhand Sir Prince Duke Lawrence Stuffingtons III!";
            Char2name.text = ""; ;
            Char2speech.text = "";
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mom"; ;
            Char2speech.text = "Huh?";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "Me";
            Char1speech.text = "I know you took him from me ‘cause you want me to give up my night light!";
            Char2name.text = ""; ;
            Char2speech.text = "";

        }
        else if (primeInt == 6)
        {

            Char1name.text = "Me";
            Char1speech.text = " I don’t even need it anymore, I already defeated the biggest monster of all!";
            Char2name.text = ""; 
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            scene3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mom"; ;
            Char2speech.text = "Hahahaha!";


        }
        else if (primeInt == 8)
        {

            Char2speech.text = "Let’s go back to your room for a second.";
        }
        else if (primeInt == 9)
        {
            scene4.SetActive(true);
            Char2speech.text = "Sir Prince Duke Lawrence Stuffingtons III is on your bed, see ?";

            // animation end calls Next();

        }
        else if (primeInt == 10)
        {
            scene5.SetActive(true);
            DialogueDisplay.SetActive(false);

        }
        else if (primeInt == 11)
        {
            DialogueDisplay.SetActive(true);
            Char1name.text = "Me";
            Char1speech.text = " What!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mom"; ;
            Char2speech.text = "I put him there because I knew you would be scared to leave your nightlight off,";
        }
        else if (primeInt == 13)
        {
            Char2speech.text = "so I wanted to make sure you had a friend.";
        }
        else if (primeInt == 14)
        {
            Char1name.text = "Me";
            Char1speech.text = " I was looking for him everywhere…!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mom"; ;
            Char2speech.text = "Hahaha, come on, let’s get you to bed.";
        }
        else if (primeInt == 16)
        {
            scene6.SetActive(true);
            Char1name.text = "Me";
            Char1speech.text = " ...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 17)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mom"; ;
            Char2speech.text = "What's the matter...?";
        }
        else if (primeInt == 18)
        {
            Char1name.text = "Me";
            Char1speech.text = " I’m still kinda scared… ";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 19)
        {
            Char1speech.text = "To sleep with the lights out.";
        }
        else if (primeInt == 20)
        {
            scene7.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mom"; ;
            Char2speech.text = "It’s okay to be scared. ";
        }
        else if (primeInt == 21)
        {
            Char2speech.text = "As long as you aren’t scared alone.";
        }
        else if (primeInt == 22)
        {
            scene1.SetActive(true);
            thankyou.SetActive(true);
            NextSceneButton.SetActive(true);
            DialogueDisplay.SetActive(false);
            nextButton.SetActive(false);
            scene2.SetActive(false);
            scene3.SetActive(false);
            scene4.SetActive(false);
            scene5.SetActive(false);
            scene6.SetActive(false);
            scene7.SetActive(false);
        }

        //Please do NOT delete this final bracket that ends the Next() function:
    }


    public void SceneChange()
    {
        SceneManager.LoadScene("Title");
    }

}
