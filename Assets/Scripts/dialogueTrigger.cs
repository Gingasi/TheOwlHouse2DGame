using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialogueTrigger : MonoBehaviour
{
    public Message[] messages;
    public Actor[] actors;

    public void StartDialogue()
    {
        FindObjectOfType<dialogueManager>().OpneDialogue(messages, actors);
    }
}


[System.Serializable]public class Message
{
    public int actorID;
    public string message;
}

[System.Serializable]public class Actor
{
    public string name;
    public Sprite sprite;
}