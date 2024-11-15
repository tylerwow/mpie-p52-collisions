using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public bool GetActive() {
        GameObject parent = transform.parent.gameObject;
        return parent.activeInHierarchy;
    }

    void OnTriggerEnter(Collider other) {
        GameObject parent = transform.parent.gameObject;
        
        AudioSource reload = parent.GetComponent<AudioSource>();
        reload.Play();
        
        parent.SetActive(false);
    }
}
