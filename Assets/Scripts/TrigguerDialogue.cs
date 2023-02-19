using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigguerDialogue : MonoBehaviour
{

    public bool isTrigerOn;
    public GameObject CharSprite;


    void Start()
    {
        //dialogManager = FindObjectOfType<TriggerDialogue>();
        isTrigerOn = false;
        CharSprite.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("MAIN_CHar"))
        {
            isTrigerOn = true;
            CharSprite.SetActive(true);
            Time.timeScale = 0f;
        }
    }

   public void ButtonClose()
    {
        isTrigerOn = false;
        CharSprite.SetActive(false);
        Time.timeScale = 1f;
    }


}

