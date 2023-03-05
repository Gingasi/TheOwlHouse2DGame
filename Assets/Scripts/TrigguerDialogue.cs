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

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Luz"))
        {
            isTrigerOn = true;
            Character1.SetActive(true);
            Time.timeScale = 0f;
        }
    }

  public void GameisOn()
    {
        isTrigerOn = false;
        Destroy(gameObject);
        Time.timeScale = 1f;
        
    }


}

