using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBullets : MonoBehaviour
{
    public Gun gun;

    int bullets;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bullets = gun.ammo;

        Text t = GetComponent<Text>();

        t.text = bullets.ToString();
    }
}
