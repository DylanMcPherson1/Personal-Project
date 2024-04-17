using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBounds : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    void CheckGameObject()
    {
        if (gameObject.activeSelf == true)
        {
            StartCoroutine(ExistCountdownRoutine());
        }
        IEnumerator ExistCountdownRoutine()
        {
            yield return new WaitForSeconds(2);
            Destroy(gameObject);
        }
    }
}
