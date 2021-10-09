using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    [SerializeField] private AudioSource StartSoundEffect;
    public void StartGame ()
    {
        StartSoundEffect.Play();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }


}
