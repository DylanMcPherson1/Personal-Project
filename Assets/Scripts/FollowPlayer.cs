using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject playerPrefab;
    private Vector3 offset = new Vector3(0, 0, -10);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = playerPrefab.transform.position + offset;
        if (transform.position.y > 1)
        {
            transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        }
        if (transform.position.y <-0.3121028f)
        {
            transform.position = new Vector3(transform.position.x, -0.3121028f, transform.position.z);
        }
    }
}
