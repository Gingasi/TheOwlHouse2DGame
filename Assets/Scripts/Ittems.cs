using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ittems : MonoBehaviour
{
    public GameObject LightGlyps;
    public GameObject IceGlyps;
    public GameObject FireGlyps;
    public GameObject PlantGlyps;

    public GameObject LightGlypsOn;
    public GameObject IceGlypsOn;
    public GameObject FireGlypsOn;
    public GameObject PlantGlypsOn;

    private int LightG = 0;
    private int IcetG = 0;
    private int PlanthtG = 0;
    private int FireG = 0;

    private bool IsGlyphActivated = false;

    public GameObject WinPannel;


    // Start is called before the first frame update

    void Start()
    {
        IsGlyphActivated = false;
    }

    void Update()
    {
        Win();
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Light"))
        {
            Destroy(otherCollider.gameObject);
            LightG++;
            LightGlyps.SetActive(false);
            LightGlypsOn.SetActive(true);
            GlyphActivated();

        }
        if (otherCollider.gameObject.CompareTag("Ice"))
        {

            Destroy(otherCollider.gameObject);
            IcetG++;
            IceGlyps.SetActive(false);
            IceGlypsOn.SetActive(true);
            GlyphActivated();

        }
        if (otherCollider.gameObject.CompareTag("Plant"))
        {

            Destroy(otherCollider.gameObject);
            PlanthtG++;
            PlantGlyps.SetActive(false);
            PlantGlypsOn.SetActive(true);
            GlyphActivated();

        }
        if (otherCollider.gameObject.CompareTag("Fire"))
        {

            Destroy(otherCollider.gameObject);
            FireG++;
            FireGlyps.SetActive(false);
            FireGlypsOn.SetActive(true);
            GlyphActivated();
        }
  
    }

    public void GlyphActivated()
    {
        IsGlyphActivated = true;
    }

    public void Win()
    {
        if (LightG >= 10f && IcetG >= 10f && PlanthtG >= 10f && FireG >= 10f)
        {
            WinPannel.SetActive(true);
            Time.timeScale = 0;

        }
    }

    public void ReGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
