using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // This script is accessible from everywhere and exists only once (per Scene).
    public static UIManager instance;

    public Text textDisplay; // The UI element that displays dialogs etc.

    Coroutine speaking = null; // The coroutine that displays the text character after character.
    [HideInInspector] public bool isSpeaking { get { return speaking != null; } } // Returns true if the text is currently being written.
    [HideInInspector] public bool isWaitingForUserInput = false; // Returns true if the text has been written out and player input is expected.

    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Debug.LogError("UI Manager exists more than once - please delete all other UI Manager scripts.");
    }

    public void Say(string speech)
    {
        StopSpeaking();
        speaking = StartCoroutine(Speaking(speech));
    }

    IEnumerator Speaking(string speech)
    {
        textDisplay.text = "";
        isWaitingForUserInput = false;

        while (textDisplay.text != speech)
        {
            textDisplay.text += speech[textDisplay.text.Length];
            yield return new WaitForSeconds(0.05f);
        }

        isWaitingForUserInput = true;
        while (isWaitingForUserInput)
        {
            yield return new WaitForSeconds(0.05f);
        }

        StopSpeaking();
    }

    public void StopSpeaking()
    {
        if (isSpeaking)
        {
            StopCoroutine(speaking);
        }
        speaking = null;
    }
}
