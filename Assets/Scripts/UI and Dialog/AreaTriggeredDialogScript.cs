using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaTriggeredDialogScript : MonoBehaviour
{
    [Tooltip("The gameobject that holds the assigned dialog script - this will be activated when the area has been entered by the player.")]
    [SerializeField]
    GameObject dialogScript;

    void Start()
    {
        if (this.GetComponent<Collider>() == null)
        {
            Debug.LogError("No Collider has been assigned! Please assign a collider @" + this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Only works if the player enters the trigger. Make sure that the player has a collider and a rigidbody!
        {
            dialogScript.SetActive(true);
        }
    }
}
