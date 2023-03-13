using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public dialogueTrigger trigger;


    private void OnCollisionEnter2D(Collision2D Collision)
    {
        if(Collision.gameObject.CompareTag("Luz") == true)
        {

            trigger.StartDialogue();
        }
        
    }

}
