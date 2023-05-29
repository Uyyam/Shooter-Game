using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class darkTransition : MonoBehaviour
{
    public void SceneChange()
    {

        SceneManager.LoadScene("Conclusion");
    }
}
