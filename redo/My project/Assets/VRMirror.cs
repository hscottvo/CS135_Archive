using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRMirror : MonoBehaviour
{
    public OVRCameraRig cam;
    bool m_press = true;
    Vector3 cam_position;
    Quaternion headsetRotation;
    Quaternion cubeRotation;
    public GameObject parent;
    // Start is called before the first frame update
    void Start()
    {
        // cam = GetComponent<OVRCameraRig>();  
        // Debug.Log(cam.TrackingSpace.CenterEyeAnchor + "sdlkfjdslkfjdsklfjsdklfjsdklfjsdkljfsdkljflksdjfklsdjfklsdjklf");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            this.m_press = !this.m_press;
        }
        cam_position = cam.centerEyeAnchor.transform.position;
        // Debug.Log("cube: " + transform.position + "\ncamera: " + cam_position);
        headsetRotation = cam.centerEyeAnchor.rotation;
        // this.transform.position = -1 * cam_position;
        if (this.m_press)
        {
            parent.transform.rotation = Quaternion.Euler(0, 0, 0);
            this.transform.rotation = headsetRotation;
            this.transform.position = cam_position;
            this.transform.position += new Vector3(0, 0, 2);
            this.transform.Rotate(0, 270, 0);
        }
        else
        {
            // parent.transform.rotation = Quaternion.Euler(0, -90, 0);
            // reverse yaw and roll
            // this.transform.rotation = Quaternion.Inverse(headsetRotation);
            this.transform.position = Vector3.Scale(cam_position, new Vector3(1, 1, -1));
            this.transform.position += new Vector3(0, 0, 2);
            cubeRotation = headsetRotation;
            // cubeRotation = Quaternion.Euler(0, 90, 0) * cubeRotation;
            // cubeRotation.transform.Rotate(0, 90, 0);
            // cubeRotation.eulerAngles *= -1;
            cubeRotation.y *= -1;
            cubeRotation.z *= -1;
            // cubeRotation.w *= -1;
            this.transform.localRotation = cubeRotation;
            // this.transform.Rotate(0f, 180f, 0f, Space.Self);
            this.transform.localRotation = Quaternion.Euler(0, 180, 0) * this.transform.localRotation;
            // this.transform.rotation = Quaternion.Euler(0, 90, 0) * this.transform.rotation;
        }
    }
}
