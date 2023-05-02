using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundAfterDelay : MonoBehaviour
{
    public AudioSource audioSource;
    public float delays;
    //public AudioClip soundClip;

    void Start()
    {
        StartCoroutine(PlaySoundDelayed(delays));
    }

    IEnumerator PlaySoundDelayed(float delay)
    {
        yield return new WaitForSeconds(delay);
        audioSource.Play();
    }
}
