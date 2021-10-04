using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactwithkey : MonoBehaviour
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
        if (isInRange)
        {
            if (Input.GetKeyDown(interactKey))
            {
                Debug.Log("Player Used");
            }
        }
    }

    private void OnTriggerEnter(Collider collison)
    {
        if (collison.gameObject.CompareTag("Finish"))
        {
            isInRange = true;
            Debug.Log("Key is in range");
            interactAction.Invoke();
        }
    }
    private void OnTriggerExit(Collider collison)
    {
    }
}
