using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Gun : MonoBehaviour
{
    public int ammo = 0;

    public AmmoBox ammoBox;

    public Bridge bridge;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!ammoBox.GetActive()) {
            ammo = 20;
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
