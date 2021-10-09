using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMenu : MonoBehaviour
{
    [SerializeField] private AudioSource QuitMenuSoundEffect;


    public void Quit ()
    {
        QuitMenuSoundEffect.Play();
        Application.Quit();
        Debug.Log ("Game quit");


        
    }

}