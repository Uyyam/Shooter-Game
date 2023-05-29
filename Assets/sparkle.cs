using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparkle : MonoBehaviour
{
    public Conclusion conc;

    public void nextConc()
    {
        conc.Next();
    }
}
