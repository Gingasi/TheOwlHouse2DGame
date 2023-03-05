using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movefordward : MonoBehaviour
{
    private float speed = 50f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime); 
    }
}
