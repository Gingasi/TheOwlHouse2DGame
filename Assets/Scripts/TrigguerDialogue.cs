using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigguerDialogue : MonoBehaviour
{

    public bool isTrigerOn;
    public GameObject Character1;


    void Start()
    {
        //dialogManager = FindObjectOfType<TriggerDialogue>();
        isTrigerOn = false;
        Character1.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("MAIN_CHar"))
        {
            isTrigerOn = true;
            Character1.SetActive(true);
            Time.timeScale = 0f;
        }
    }

   public void ButtonClose()
    {
        isTrigerOn = false;
        Character1.SetActive(false);
        Time.timeScale = 1f;
        Destroy(gameObject);
    }


}

