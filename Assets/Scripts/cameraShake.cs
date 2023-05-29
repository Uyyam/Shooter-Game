using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraShake : MonoBehaviour
{
    //public bool start = false;

    //void Update()
    //{
    //    if (start == true)
    //    {
    //        Shake(1f, 1f);
    //    }
    //}
  
    public IEnumerator Shake(float duration, float magnitude)
    {
        Debug.Log("shaaake");
        Vector3 originalPos = new Vector3(0,0,0);

        float elapsedTime = 0f;

        while(duration > elapsedTime)
        {
            float xOffset = Random.Range(-0.5f, 0.5f) * magnitude;
            float yOffset = Random.Range(-0.5f, 0.5f) * magnitude;

            transform.localPosition = new Vector3(xOffset, yOffset, originalPos.z);

            elapsedTime += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = originalPos;
    }
}
