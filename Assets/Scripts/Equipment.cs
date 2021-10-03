using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour
{
    public bool gotflash = false;
    public GameObject Flashlight;
    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Getflash()
    {
        Flashlight.SetActive(true);
    }
}
