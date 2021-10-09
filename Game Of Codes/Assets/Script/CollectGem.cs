using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectGem : MonoBehaviour
{
    int score = 0;

    public Text scoreText;
    public Text bestScore;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        if (score > PlayerPrefs.GetInt("bestScore", 0))
        {
            PlayerPrefs.SetInt("bestScore", score);
            bestScore.text = score.ToString();


            
        }
        

    }

    public void Reset()
    {
        PlayerPrefs.DeleteAll();

        bestScore.text = "Best Score : " + bestScore.ToString();


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("RedGem"))
        {
            Destroy(collision.gameObject);
            score = score + 100;
            scoreText.text = "Score : " + score.ToString();

        }
        else if (collision.gameObject.CompareTag("GreenGem"))
        {
            Destroy(collision.gameObject);
            score = score + 50;
            scoreText.text = "Score : " + score.ToString();

        }
        else if (collision.gameObject.CompareTag("BlueGem"))
        {
            Destroy(collision.gameObject);
            score = score + 20;
            scoreText.text = "Score : " + score.ToString();

        }
    }

}
