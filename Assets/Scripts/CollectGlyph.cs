using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectGlyph : MonoBehaviour
{
    public GameObject[] Prefab;
    private float startTime = 2f;
    private float repeatRate = 5f;
    private Vector2 InitialPos = Vector2.zero;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPrefab", startTime, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector3 RandomPosition()
    {
        return new Vector3(0f, Random.Range(90f, 95f), 0f);
    }
    public void SpawnPrefab()
    {
        InitialPos = RandomPosition();
        Instantiate(Prefab[1], InitialPos,
            transform.rotation);
    }
}
