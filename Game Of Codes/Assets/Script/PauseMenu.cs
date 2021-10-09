using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPause = false;

    public GameObject pauseMenuUI;
    [SerializeField] private AudioSource PauseMenuSoundEffect;
    [SerializeField] private AudioSource ResumeSoundEffect;
    [SerializeField] private AudioSource PauseSoundEffect;
    [SerializeField] private AudioSource LoadMenuSoundEffect;
    [SerializeField] private AudioSource QuitMenuSoundEffect;




    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseSoundEffect.Play();
            if (GameIsPause)
            {
                Resume ();
            }
            else
            {
                Pause ();
            }



        }



    }

    public void Resume()
    {
        ResumeSoundEffect.Play();
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPause = false;


    }

    void Pause ( )
    {
        PauseSoundEffect.Play();
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPause = true;
    }



    public void LoadMenu()
    {
        LoadMenuSoundEffect.Play();
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");

    }

    public void QuitGame()
    {
        QuitMenuSoundEffect.Play();
        Application.Quit();

    }


}
