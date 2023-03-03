using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightFlicker : MonoBehaviour
{
    public GameObject parent;
    public float timer = 0.0f;
    public int random_number;
    private int new_random_number;
    public float timer_max = 20f;
    // public Light child_list;
    // Start is called before the first frame update
    void Start()
    {
        // parent = GetComponent<GameObject>();
        Debug.Log(this.transform.childCount + " children");
        // child_list = this.GetComponentInChildren<Light>();
        change_light();
    }

    public Transform current_child(){
        return this.transform.GetChild(this.random_number);
    }

    public void change_light(){
        do {
                new_random_number = Random.Range(0, this.transform.childCount);
            } while (new_random_number == random_number);
        random_number = new_random_number;
        Debug.Log("Choosing child " + random_number);
        for (int i = 0; i < this.transform.childCount; ++i){
            var child = this.transform.GetChild(i);
            if (i == random_number){
                // Debug.Log("Turning on child light " + random_number);
                child.GetComponent<Light>().intensity = 1f;
            } else {
                // Debug.Log("Turning off child light " + random_number);
                child.GetComponent<Light>().intensity = 0;
            }
        }
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= timer_max){
            // random_number = Random.Range(0, this.transform.childCount);
            change_light();
        }
    }
}
