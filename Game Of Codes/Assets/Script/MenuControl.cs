using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuControl : MonoBehaviour
{

    int x;
    int y;

    public Text BestScore;
    public Text YourScore;

    void Start()
    {

        x = PlayerPrefs.GetInt("bestScore");
        y = PlayerPrefs.GetInt("finalyourscore");

        BestScore.text = "Best Score : " + PlayerPrefs.GetInt("bestScore");
        YourScore.text = "Your Score : " + PlayerPrefs.GetInt("finalyourscore");
        

    }


    void Update()
    {

    }
}
