using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    public int ammo = 0;

    public AmmoBox ammoBox;

    public Bridge bridge;

    bool hasAmmo = false;

    // Update is called once per frame
    void Update()
    {
        if (!ammoBox.GetActive() && !hasAmmo) {
            ammo = 20;
            hasAmmo = true;
        }

        if (ammo == 0 && Input.GetButtonDown("Fire1")) {
            AudioSource noAmmo = GetComponent<AudioSource>();
            noAmmo.Play();
        }

        if (ammo > 0 && Input.GetButtonDown("Fire1")) {

            
            Ray ray =  Camera.main.ViewportPointToRay(new Vector3(0.5f ,0.5f ,0.0f));
            ammo--;

            RaycastHit result;

            if (Physics.Raycast(ray, out result)) {
                bridge.LowerBridge(result);
            }
        }
    }
}
