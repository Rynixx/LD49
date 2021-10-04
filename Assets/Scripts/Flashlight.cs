using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    Light testlight;

    public float minWaitTime;
    public float maxWaitTime;

    // Start is called before the first frame update
    void Start()
    {
        // i = GetComponent<Light>;
        testlight = GetComponent<Light>();
        
    }
    public void flicker()
    {
        StartCoroutine(Flashing());
    }

IEnumerator Flashing()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minWaitTime,maxWaitTime));
            testlight.enabled = !testlight.enabled;
        }
    }
}
