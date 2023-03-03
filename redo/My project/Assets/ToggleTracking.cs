using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleTracking : MonoBehaviour
{
    public OVRCameraRig cam;
    bool rotate = true;
    bool position = true;
    Vector3 anchor_angles;
    Quaternion cache_angle;
    // Start is called before the first frame update
    void Start()
    {
        // UnityEngine.XR.InputTracking.disablePositionalTracking = position;
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log("anchor: " + Quaternion.Euler(cam.centerEyeAnchor.transform.eulerAngles) + "camerarig: " + this.transform.rotation);
        // Debug.Log("anchor: " + cam.centerEyeAnchor.transform.eulerAngles + "\ncamerarig: " + this.transform.eulerAngles);
        // Debug.Log("cache: " + cache_angle.eulerAngles);
        if (Input.GetKeyDown(KeyCode.P))
        {
            
            position = !position;
            // UnityEngine.XR.InputTracking.disablePositionalTracking = position;
            
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            // cache_angle = this.transform.rotation;
            cache_angle = cam.centerEyeAnchor.transform.localRotation;
            rotate = !rotate;
        }
        if (!position) {
            // Debug.Log("old position: " + this.transform.position + "\nanchor position: " + cam.centerEyeAnchor.transform.position);
            this.transform.position = this.transform.position - cam.centerEyeAnchor.transform.position;
        }

        if(!rotate) {
            // Debug.Log(this.transform.rotation);
            // Debug.Log("Rotating");
            Quaternion cam_quaternion = cam.centerEyeAnchor.transform.localRotation;
            // cam_quaternion.w *= -1;
            // Debug.Log(this.transform.rotation + " " + cam_quaternion);
            // Debug.Log(cam_quaternion);
            // this.transform.rotation = cam_quaternion;
            // this.transform.rotation = cache_angle * Quaternion.Euler(0, 180, 0) * Quaternion.Inverse(cam_quaternion);
            this.transform.rotation = cache_angle * Quaternion.Inverse(cam_quaternion);

        } 
        
    }
}
