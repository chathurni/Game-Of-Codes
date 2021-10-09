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

    [SerializeField] private AudioSource RgemCollectSoundEffect;
    [SerializeField] private AudioSource GgemCollectSoundEffect;
    [SerializeField] private AudioSource BgemCollectSoundEffect;
    [SerializeField] private AudioSource ResetSoundEffect;


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
        ResetSoundEffect.Play();
        PlayerPrefs.DeleteAll();

        bestScore.text = "Best Score : " + bestScore.ToString();


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
