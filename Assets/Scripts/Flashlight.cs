using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public float minTime = 0.02f;
    public float maxTime = 1.0f;
    private float Timer;
    private Light i;


    // Start is called before the first frame update
    void Start()
    {
       // i = GetComponent<Light>;
        Timer = Random.Range(minTime, maxTime);
    }

    // Update is called once per frame
    void Update()
    {
       // Timer -= ();
    }
}
