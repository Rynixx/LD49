using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Insanity : MonoBehaviour
{
    // Start is called before the first frame update
    public int InsanityValue = 0;

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
        if(InsanityValue < 100)
        {
            // Unity Events
            if (InsanityValue < 250)
                {
            // Unity Events
        
                 if (InsanityValue < 50)
                    {
            // Unity Events
        }
    }
    public void Teleport()
    {
        Vector3 pos = transform.position;
        pos.y = Random.Range(.3f, 1.0f);
        transform.position = pos;
    }
}