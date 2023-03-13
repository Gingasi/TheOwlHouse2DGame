using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int Healthmax = 100;
    public int Healthmin = 0;
    public int Healthcurrent;
  

    public Animator anim;
   

    

    void Start() 
    {
        Healthcurrent = Healthmax;
        
    }
    void DamageTake(int damage) 
    {
        Healthcurrent -= damage;
       
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Hit"))
        {
            DamageTake(5);
            

        }


    }

    private void Update()
    {
        Death();
    }

    void Death()
    {
        if (Healthcurrent <= Healthmin)
        {
            StartCoroutine(AnimDeath());
            

        }

    }

    private IEnumerator AnimDeath() 
    {
        anim.SetTrigger("Death");
        yield return new WaitForSeconds(2);
        
        gameObject.SetActive(false);
    }
}
