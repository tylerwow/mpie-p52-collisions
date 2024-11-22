using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Help : MonoBehaviour
{
    private IEnumerator coroutine;

    Text t;

    public Gun gun;

    public CheckPath checkPath;

    public Bridge bridge;
    

    void Start() {
        t = GetComponent<Text>();
    }

    void Update() {
        if (!gun.hasAmmo) {
            coroutine = WaitAndDisplay(5.0f, "I wonder if there is any ammo in that shack?");
        }
        else if (!checkPath.hasPath) {
            coroutine = WaitAndDisplay(5.0f, "What is up that path?");
        }
        else if (!bridge.hasBridge) {
            coroutine = WaitAndDisplay(5.0f, "What is the target?");
        }
        StartCoroutine(coroutine);
    }

    private IEnumerator WaitAndDisplay(float waitTime, string msg) {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            t.text = msg;
        }
    }
}
