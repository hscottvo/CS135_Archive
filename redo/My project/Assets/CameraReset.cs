using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraReset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            // Debug.Log("resetting cam position");
            var cam_position = transform.GetChild(0).GetChild(1).position;
            this.transform.position = transform.position - cam_position;
        }
    }
}
