using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ExampleSoundTriggerScript : MonoBehaviour
{
    // Assign the right GameObject to this event and then the PlaySound() as a function.
    public UnityEvent soundTriggerEvent;
    // Assign the right GameObject to this event and then the StopSound() as a function.
    public UnityEvent soundStopEvent;

    private void Update()
    {
        // Links Click
        if (Input.GetMouseButtonDown(0)) {
            soundTriggerEvent.Invoke();
        }
        // Rechts Click
        if (Input.GetMouseButtonDown(1))
        {
            soundStopEvent.Invoke();
        }
    }
}
