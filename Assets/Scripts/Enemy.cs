using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Animator EnemyAtn;
    public GameObject Attack;
    public GameObject ShootPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D otherCollider)
    {

        if (otherCollider.gameObject.CompareTag("Luz"))
        {
            Debug.Log("Fire");
            EnemyAtn.SetBool("Attack", true);

            Instantiate(Attack, ShootPoint.transform.position,
                        ShootPoint.transform.rotation);
        }
        else
        {
            EnemyAtn.SetBool("Attack", false);
        }
    }
        /*
            if (otherCollider.gameObject.CompareTag("FAt"))
            {
                Debug.Log("Fire");
                EnemyAtn.SetBool("DFire", true);
                Destroy(otherCollider.gameObject);
            }

            if (otherCollider.gameObject.CompareTag("PAt"))
            {
                Debug.Log("Plant");
                EnemyAtn.SetBool("DPlant", true);
                Destroy(otherCollider.gameObject);
            }

            if (otherCollider.gameObject.CompareTag("IAt"))
            {
                Debug.Log("Ice");
                EnemyAtn.SetBool("DIce", true);
                Destroy(otherCollider.gameObject);
            }
        }*/
    }
