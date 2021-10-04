using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogScript : MonoBehaviour
{
    UIManager uiManager;

    [TextArea(minLines: 2, maxLines: 4)]
    [Tooltip("Add text here. Each string represents the text that will be displayed at once.")]
    [SerializeField]
    private string[] dialog;

    int index = 0;

    void Start() // This gameobject should be inactive in scene at first. As soon as the gameobject is set active, the text appears.
    {
        uiManager = UIManager.instance;
        Say(dialog[index]);
        ++index;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown /* add here a condition that checks the game state - you should paralyze the player while the text is playing. */)
        {
            if (!uiManager.isSpeaking || uiManager.isWaitingForUserInput)
            {
                if (index >= dialog.Length)
                {
                    uiManager.textDisplay.text = "";
                    this.gameObject.SetActive(false);
                    return;
                }

                Say(dialog[index]);
                ++index;
            }
        }
    }

    void Say(string s)
    {
        uiManager.Say(s);
    }
}
