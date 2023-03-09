using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGlyph : MonoBehaviour
{
    public float Speed = 5f;



    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Speed * Time.deltaTime);


    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.CompareTag("Enemy"))
        {
            print("Hit Enemy");

            Destroy(this.gameObject);
        }


       

    }
}
