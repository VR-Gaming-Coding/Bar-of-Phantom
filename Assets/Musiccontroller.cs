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

    public void PlayMusic()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }
    }
}
