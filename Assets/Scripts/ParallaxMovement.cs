using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
   private float lenght, startpos;
   public GameObject Cam;
    public float parallaxEffect;

    private void Start()
    {
        startpos = transform.position.x;
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    private void FixedUpdate()
    {
        float temp = (Cam.transform.position.x * (1 - parallaxEffect));
        float dist = (Cam.transform.position.x * parallaxEffect);

        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        if (temp > startpos + lenght)
        {
            startpos += lenght;
        }
            
        else if (temp < startpos - lenght)
        {
            startpos -= lenght;
        }


    }

}
