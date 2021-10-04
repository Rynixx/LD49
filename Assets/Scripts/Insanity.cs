using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Insanity : MonoBehaviour
{
    // Start is called before the first frame update
    public int InsanityValue = 0;

    public bool Level1 = false;
    public bool Level2 = false;
    public bool Level3 = false;
    public UnityEvent insanityhandler1;
    public UnityEvent insanityhandler2;
    public UnityEvent insanityhandler3;
    public static Insanity instance;

    void Awake()
    {
       // instance = this;
    }
    public void Start()
    {
        StartCoroutine(time());
    }
    IEnumerator time()
    {
        while (true)
        {
            timeCount();
            yield return new WaitForSeconds(1);
        }
    }
    void timeCount()
    {
        InsanityValue += 1;
    }
    private void Update()
    {
        
        if (InsanityValue == 100)
        {
            Level1 = true;
            Level2 = false;
            Level3 = false;
            insanityhandler1.Invoke();
        }
        if (InsanityValue == 200)
        {
            Level2 = true;
            Level3 = false;
            insanityhandler2.Invoke();
        }
        if (InsanityValue == 500)
        {
            Level3 = true;
            insanityhandler3.Invoke();
            
        }
    }
    //public void stage1()
}