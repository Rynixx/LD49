using System.Collections;
using UnityEngine.Events;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey;
    public UnityEvent interactAction;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                Debug.Log("Player Used");
                animator.Play("DoorOpen");
            }
        }
    }

    private void OnTriggerEnter(Collider collison)
    {
        if (collison.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player is in range");
        }
    }
    private void OnTriggerExit(Collider collison)
    {
        if (collison.gameObject.CompareTag("Player"))
        {
            isInRange = false;
            Debug.Log("Player is now out of range");
            animator.Play("DoorClose");
        }
    }
}
