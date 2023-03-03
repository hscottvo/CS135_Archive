using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateStimuli : MonoBehaviour
{
    public GameObject red;
    public GameObject blue_one;
    public GameObject blue_two;
    bool waiting = false;
    bool active = true;
    float timer = 0f;
    // Start is called before the first frame update
    float dist_red;
    float dist_one; 
    float dist_two;
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S) && !waiting) {
            timer = 0;
            waiting = true;
            active = !active;
            red.SetActive(active);
        }
        if (waiting) {
            timer += Time.deltaTime;
            if (timer >= 2.0f) {
                waiting = false;
                blue_one.SetActive(active);
                blue_two.SetActive(active);
            }
        }
        dist_red = Vector3.Distance(this.transform.position, red.transform.position);
        dist_one = Vector3.Distance(this.transform.position, blue_one.transform.position);
        dist_two = Vector3.Distance(this.transform.position, blue_two.transform.position);
        blue_one.transform.localScale = (red.transform.localScale / dist_red) * dist_one;
        blue_two.transform.localScale = (red.transform.localScale / dist_red) * dist_two;
    }
}
