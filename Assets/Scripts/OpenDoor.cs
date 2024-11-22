using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        GameObject parent = transform.parent.gameObject;       
        Animation animation = parent.GetComponent<Animation>();       
        animation.Play("OpenDoor");

        AudioSource doorOpen = parent.GetComponent<AudioSource>();
        doorOpen.Play();
    }
}
