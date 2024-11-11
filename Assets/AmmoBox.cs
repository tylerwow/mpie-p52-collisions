using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool GetActive() {
        GameObject parent = transform.parent.gameObject;
        return parent.activeInHierarchy;
    }

    void OnTriggerEnter(Collider other) {
        GameObject parent = transform.parent.gameObject;
        parent.SetActive(false);
    }
}
