using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] audioClips;

    public void ChangeAudioTrack(int index)
    {
        audioSource.clip = audioClips[index];
        audioSource.Play();
    }

    public void StopAudioTtack()
    {
        audioSource.Pause();
    }
}
