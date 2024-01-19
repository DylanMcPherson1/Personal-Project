using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject garbagePrefab;
    public GameObject toxicPrefab;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnItems", 0.5f, 2f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnItems()
    {
        Instantiate(garbagePrefab, new Vector2(5f, Random.Range(-5.0f, 5f)), Quaternion.identity);
        Instantiate(toxicPrefab, new Vector2(5f, Random.Range(-5.0f, 5f)), Quaternion.identity);
    }

}
