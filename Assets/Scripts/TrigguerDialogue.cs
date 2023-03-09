using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigguerDialogue : MonoBehaviour
{

    public static bool isTrigerOn;
    public GameObject Character1;
    public bool AttackIsOn;


    void Start()
    {
        //dialogManager = FindObjectOfType<TriggerDialogue>();
        isTrigerOn = false;
        Character1.SetActive(false);
        AttackIsOn = false;
        Time.timeScale = 1;
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("Luz"))
        {
            isTrigerOn = true;
            Character1.SetActive(true);
            Time.timeScale = 0;
        }
     

        if (otherCollider.gameObject.CompareTag("GlyphAttack"))
        {
            isTrigerOn = true;
            Character1.SetActive(true);
            Time.timeScale = 0;
            AttackIsOn = false;
        }
       
    }

  public void GameisOn()
    {
        isTrigerOn = false;
        Time.timeScale = 1;
        Debug.Log("Holli");
        Destroy(gameObject);
        AttackIsOn = true;
    }

}

