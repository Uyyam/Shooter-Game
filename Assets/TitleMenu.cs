using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{
    public GameObject beginGame;
    public GameObject credit;
    public GameObject Exit;
    public GameObject creditStuff;
    public GameObject title;
    public GameObject subTitle;
    public AudioSource song;
    // Start is called before the first frame update
    void Start()
    {
        beginGame.SetActive(true);
        credit.SetActive(true);
        Exit.SetActive(true);
        title.SetActive(true);
        subTitle.SetActive(true);
        creditStuff.SetActive(false);
        var audio = GameObject.FindGameObjectWithTag("Music").GetComponent<AudioSource>();
        if (audio.isPlaying == true)
        {
            song.Stop();
        }
        song.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame()
    {
        SceneManager.LoadScene("Intro");
    }

    public void credits()
    {
        //make shit visible
        title.SetActive(false);
        subTitle.SetActive(false);
        beginGame.SetActive(false);
        credit.SetActive(false);
        Exit.SetActive(false);
        creditStuff.SetActive(true);
    }

    public void back()
    {
        title.SetActive(true);
        subTitle.SetActive(true);
        beginGame.SetActive(true);
        credit.SetActive(true);
        Exit.SetActive(true);
        creditStuff.SetActive(false);
    }

    public void quitGame()
    {
        Application.Quit();

    }
}
