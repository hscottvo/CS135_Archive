using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreKeeper : MonoBehaviour
{
    // Start is called before the first frame update
    public lightFlicker parent;
    private int score = 0;
    [SerializeField]
    private Text scoreText;
    void Start()
    {

    }

    public void IncScore()
    {
        score += 1;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + score.ToString() + "\n Time left: " + Mathf.Round((parent.timer_max - parent.timer)*10f) * 0.1f;;
    }
}
