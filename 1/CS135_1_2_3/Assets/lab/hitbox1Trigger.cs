using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitbox1Trigger : MonoBehaviour
{
    public lightFlicker parent;
    public scoreKeeper score;
    // Start is called before the first frame update
    void Start()
    {
        // light = GetComponent<Light>();
        // light.color = Color.black;
    }
    
    void OnTriggerStay(Collider other)
    {
        // Debug.Log("test");
        if (OVRInput.Get(OVRInput.Button.One)){
            Debug.Log("current child: " + parent.current_child().name);
            Debug.Log("current hitbox: " + transform.parent.name);
            if(parent.current_child() == this.transform.parent){
                Debug.Log("point!");
                parent.change_light();
                score.IncScore();

            } else {
                Debug.Log("no point!");
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // light.color = light_enter ? Color.black : Color.white;
    }
}
