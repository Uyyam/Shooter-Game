using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject retry;
    public GameObject mainMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart()
    {
        SceneManager.LoadScene("Game");
    }

    public void backMenu()
    {
        SceneManager.LoadScene("Title");
    }

    public void quitGame()
    {
        Application.Quit();
    
    }
}
