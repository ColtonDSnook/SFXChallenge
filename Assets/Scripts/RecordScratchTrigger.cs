using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordScratchTrigger : MonoBehaviour
{
    public AudioSource recordScratch;
    private void OnTriggerEnter(Collider other)
    {
        recordScratch.Play();
    }
}
