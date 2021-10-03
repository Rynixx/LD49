using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shakeeffect : MonoBehaviour
{
    public Camerashake camerashake;
    // Start is called before the first frame update
    void OnEnable()
    {

    }

    // Update is called once per frame
    void OnDisable()
    {
        
    }
     public void Camerashake()
    {
        StartCoroutine(camerashake.Shake(.15f, .4f));
        Debug.Log("Camera Wiggle");
    }
}
