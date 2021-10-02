using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventSoundScript : MonoBehaviour
{
    // This is the Audio Source that holds and plays the sound. It assignes the attached AudioSource at game start.
    // Check if an AudioSource component has been added to this game object!
    // Check beforehand if the Audioclip has been assigned!
    AudioSource theAudioSource;

    [Header("Sound Attributes")]
    [Tooltip("This sound plays once and then dies afterwards. This can also be checked later on and be used as a loop stopper.")]
    public bool playOnce;
    [Tooltip("Should this sound be stopped immediately? If not checked, the sound will finish first before stopping.")]
    public bool stopImmediately;

    private void Start()
    {
        theAudioSource = GetComponent<AudioSource>();

        // Check if the AudioSource has been assigned.
        if (theAudioSource == null)
        {
            Debug.LogError("No AudioSource component has been added to this game object! @" + this.gameObject);
            return;
        }
        // Check if the sound has been assigned.
        if (theAudioSource.clip == null)
        {
            Debug.LogError("No AudioClip has been added to the AudioSource! @" + this.gameObject);
            return;
        }
    }

    public void PlaySound()
    {
        theAudioSource.Play();

        if (playOnce)
        {
            // Stop the loop first, if the sound is looping
            if (theAudioSource.loop)
            {
                theAudioSource.loop = false;
            }

            StopSound();
        }
    }

    public void StopSound()
    {
        // Stop loop first
        theAudioSource.loop = false;

        if (stopImmediately)
        {
            theAudioSource.Stop();
        }
        else
        {
            StartCoroutine(waitForSound());
        }
    }

    IEnumerator waitForSound()
    {
        // Wait until sound has finished playing
        while (theAudioSource.isPlaying)
        {
            yield return null;
        }

        theAudioSource.Stop();
    }


}
