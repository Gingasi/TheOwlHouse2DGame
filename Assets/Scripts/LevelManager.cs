using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
    public void Level1()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);  


    }

    public void Level2()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);  


    }

    public void Level3()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);  


    }

    public void Level4()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);  


    }

    public void Level5()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);  


    }

    public void Level6()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);  


    }
    public void Level7()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);  


    }
    public void Level8()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);  


    }
    public void Level9()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);  


    }
    public void BonusLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);  


    }

    public void BackMenu()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


    }
}
