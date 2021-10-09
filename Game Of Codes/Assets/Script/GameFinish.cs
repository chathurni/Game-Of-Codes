using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFinish : MonoBehaviour
{
        private bool levelCompleted = false;

      private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name =="Player" && !levelCompleted)
        {
            
            levelCompleted = true;
            Invoke("CompleteLevel", 0.2f);

        }
        
            
    }

    private void CompleteLevel ()
    {

        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex +1);
    }
}
