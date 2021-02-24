using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class uiscript : MonoBehaviour
{
    private int score;
    private int winscore;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Lights Collected: " + score;
    }

    public void updateScore(int point)
    {
        score += point;
    }
}