using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectGem : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public Text highScore;

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
