using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxMovement : MonoBehaviour
{
    [SerializeField] private float MultipliyerCam;

    private Transform CameraTransform;
    private Vector3 PreviousCameraMovement;
    private float spriteWidth, startPosition;


    // Start is called before the first frame update
    void Start()
    {
        CameraTransform = Camera.main.transform;
        PreviousCameraMovement = CameraTransform.position;
        startPosition = transform.position.x;
    }

   void LateUpdate()
    {
        float deltaX = (CameraTransform.position.x - PreviousCameraMovement.x) * MultipliyerCam;
        float moveAmount = CameraTransform.position.x * (1 - MultipliyerCam);
        transform.Translate(new Vector3(deltaX, 0, 0));
        PreviousCameraMovement = CameraTransform.position;

        if(moveAmount > startPosition + spriteWidth)
        {
            transform.Translate(new Vector3(spriteWidth, 0, 0));
            startPosition += spriteWidth;
        }
        
    }
}
