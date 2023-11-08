using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public AudioSource yeah;
    private void OnTriggerEnter(Collider other)
    {
        yeah.Play();
    }
}
