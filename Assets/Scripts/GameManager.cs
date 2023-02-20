using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   
    private void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.name.Equals("MAIN_CHar"))
        {
            NextLevel();
        }
    }

public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
