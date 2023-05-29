using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catscript : MonoBehaviour
{
    public bool cat = false;
    public AudioSource sound;

    public void playSound()
    {
        sound.Play();
    }

    public bool catGone()
    {
        return cat = true;
    }
}
