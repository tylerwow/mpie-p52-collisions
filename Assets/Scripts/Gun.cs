using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    public int ammo = 0;

    public AmmoBox ammoBox;

    public Bridge bridge;

    public bool hasAmmo = false;

    public AudioClip noAmmo;
    public AudioClip gunShot;

    void FixedUpdate()
    {
        if (!ammoBox.GetActive() && !hasAmmo) {
            ammo = 20;
            hasAmmo = true;
        }

        if (ammo == 0 && Input.GetButtonDown("Fire1")) {
            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = noAmmo;
            audio.Play();
        }

        if (ammo > 0 && Input.GetButtonDown("Fire1")) {
            Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
            ammo--;

            AudioSource audio = GetComponent<AudioSource>();
            audio.clip = gunShot;
            audio.Play();

            RaycastHit result;

            if (Physics.Raycast(ray, out result)) {
                bridge.LowerBridge(result);
            }
        }
    }
}
