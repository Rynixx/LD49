using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class ShipManager : MonoBehaviour
{

    // Start is called before the first frame update
    public int ShipValue = 0;

    public bool ShipLevel1 = false;
    public bool ShipLevel2 = false;
    public bool ShipLevel3 = false;
    public UnityEvent Shiphandler1;
    public UnityEvent Shiphandler2;
    public UnityEvent Shiphandler3;
    public static ShipManager instance;

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
        ShipValue += 1;
    }
    private void Update()
    {

        if (ShipValue == 100)
        {
            ShipLevel1 = true;
            ShipLevel2 = false;
            ShipLevel3 = false;
            Shiphandler1.Invoke();
        }
        if (ShipValue == 250)
        {
            ShipLevel2 = true;
            ShipLevel3 = false;
            Shiphandler2.Invoke();
        }
        if (ShipValue == 500)
        {
            ShipLevel3 = true;
            Shiphandler3.Invoke();
        }
    }
    //public void stage1()
}