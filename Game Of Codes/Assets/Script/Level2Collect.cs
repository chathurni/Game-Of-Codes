using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level2Collect : MonoBehaviour
{
    int highscore = 0;
    int score = 0;

    public Text scoreText;
    public Text bestScore;

    [SerializeField] private AudioSource RgemCollectSoundEffect;
    [SerializeField] private AudioSource GgemCollectSoundEffect;
    [SerializeField] private AudioSource BgemCollectSoundEffect;
    [SerializeField] private AudioSource ResetSoundEffect;


    private void Start()
    {
        highscore = PlayerPrefs.GetInt("bestScore");
        score = PlayerPrefs.GetInt("yourscore");


    }

    private void Update()
    {
        if (score > highscore)
        {
            PlayerPrefs.SetInt("bestScore", score);
            bestScore.text = score.ToString();

        }
        else
        {
            PlayerPrefs.SetInt("finalyourscore", score);
        }


    }

    public void Reset()
    {
        ResetSoundEffect.Play();
        PlayerPrefs.DeleteAll();


    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("RedGem"))
        {
            RgemCollectSoundEffect.Play();
            Destroy(collision.gameObject);
            score = score + 100;
            scoreText.text = "Score : " + score.ToString();

        }
        else if (collision.gameObject.CompareTag("GreenGem"))
        {
            GgemCollectSoundEffect.Play();
            Destroy(collision.gameObject);
            score = score + 50;
            scoreText.text = "Score : " + score.ToString();

        }
        else if (collision.gameObject.CompareTag("BlueGem"))
        {
            BgemCollectSoundEffect.Play();
            Destroy(collision.gameObject);
            score = score + 20;
            scoreText.text = "Score : " + score.ToString();

        }
    }

}
