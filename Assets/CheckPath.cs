using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CheckPath : MonoBehaviour
{
    public bool hasPath = false;

    void OnTriggerEnter() {
        hasPath = true;
    }
}