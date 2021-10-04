using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControler : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isOpen;
    public Animator animator;

   public void OpenDoor()
    {
        if(!isOpen)
        { 
            isOpen = true;
            Debug.Log("Door Opens");
            animator.SetBool("IsOpen",isOpen);
        }
    }
}
