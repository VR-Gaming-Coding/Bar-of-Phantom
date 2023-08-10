using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musiccontroller : MonoBehaviour
{
public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void StopAllAudioSources()
    {
        // Find all AudioSources in the scene and stop them
        AudioSource[] audioSources = FindObjectsOfType<AudioSource>();

        foreach (AudioSource audioSource in audioSources)
        {
            audioSource.Stop();
        }
    }
    public void PlayMusic()
    {
        StopAllAudioSources();
        audioSource.Play();
    }
    public void PlaySound()
    {
        audioSource.Play();
    }
}
