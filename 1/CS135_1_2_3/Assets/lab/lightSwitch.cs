using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightSwitch : MonoBehaviour
{
    public Light light;
    bool light_on = true;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    public void Toggle(bool enable){ 
        light.intensity = enable ? 100 : 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.Get(OVRInput.Button.One))
        {
            light_on = !light_on;
            if (light_on)
            {
                light.color = Color.white;
            }
            else
            {
                light.color = Color.black;
            }
        }
    }
}
