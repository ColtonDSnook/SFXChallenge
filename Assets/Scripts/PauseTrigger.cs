using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTrigger : MonoBehaviour
{
    public AudioSource discoMusic;
    public AudioSource pause;
    private void OnTriggerEnter(Collider other)
    {
        pause.Play();
        discoMusic.Pause();
    }
    private void OnTriggerExit(Collider other)
    {
        discoMusic.Play();
    }
}
