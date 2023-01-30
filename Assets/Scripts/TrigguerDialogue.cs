using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrigguerDialogue : MonoBehaviour
{
    public string npcName;
    public string npcDialog;
    private DialogManager dialogManager;
    public bool isTrigerOn;
    public GameObject CharSprite;


    void Start()
    {
        //dialogManager = FindObjectOfType<TriggerDialogue>();
        isTrigerOn = false;
        CharSprite.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       /* if (isPlayerInDialogZone)
        {
            //dialogManager.ShowDialog(DialogPlusNPCName());
        }    */    
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name.Equals("Hooty"))
        {
            isTrigerOn = true;
            CharSprite.SetActive(true);
            Time.timeScale = 0f;
        }
    }

   


}

