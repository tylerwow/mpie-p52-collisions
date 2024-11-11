using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Bridge : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LowerBridge(RaycastHit result) {
        GameObject g = result.collider.gameObject;
        Animation a = g.transform.parent.GetComponent<Animation>();
        a.Play("LowerBridge");
    }
}