using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;

    private void Update()
    {
        if (audioSource.volume < 1)
            audioSource.volume += Time.deltaTime;
    }

    public void play(AudioClip clip)
    {
        audioSource.clip = clip;
        audioSource.Play();
    }
}
