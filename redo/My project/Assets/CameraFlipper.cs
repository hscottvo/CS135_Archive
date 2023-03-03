using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFlipper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            // this.transform.Rotate(0f, 180f, 0f, Space.World);
            this.transform.rotation = Quaternion.Euler(0, 180, 0) * this.transform.rotation;
        }
    }
}
