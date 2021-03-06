using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isOpen;
    public Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void OpenDoor()
    {
        if(!isOpen)
        { 
            isOpen = true;
            Debug.Log("Door Opens");
            animator.SetBool("isOpen", isOpen);
        }
    }
}
