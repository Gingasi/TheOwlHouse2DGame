using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private InstantianteGlyphs InstantianteGlyphsScript;

    // Start is called before the first frame update

    void Start()
    {
        InstantianteGlyphsScript = FindObjectOfType<InstantianteGlyphs>();

    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Light"))
        {
            Debug.Log("Hola,meactivo");
            Destroy(otherCollider.gameObject);
            LightG++;
            LightGlyps.SetActive(false);
            LightGlypsOn.SetActive(true);

        }
        if (otherCollider.gameObject.CompareTag("Ice"))
        {

            Destroy(otherCollider.gameObject);
            IcetG++;
            IceGlyps.SetActive(false);
            IceGlypsOn.SetActive(true);

        }
        if (otherCollider.gameObject.CompareTag("Plant"))
        {

            Destroy(otherCollider.gameObject);
            PlanthtG++;
            PlantGlyps.SetActive(false);
            PlantGlypsOn.SetActive(true);

        }
        if (otherCollider.gameObject.CompareTag("Fire"))
        {

            Destroy(otherCollider.gameObject);
            FireG++;
            FireGlyps.SetActive(false);
            FireGlypsOn.SetActive(true);

        }
  
    }

    void Update()
    {
        
    }
}
