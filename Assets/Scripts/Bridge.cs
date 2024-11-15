using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class Bridge : MonoBehaviour
{
    public void LowerBridge(RaycastHit result) {
        GameObject g = result.collider.gameObject;
        Animation a = g.transform.parent.GetComponent<Animation>();
        a.Play("LowerBridge");
    }
}