using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float verticalInput;
    private float horizontalInput;
    public float speed = 5.0f;
    public GameObject trashPrefab;
    public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.left * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector2.up * Time.deltaTime * speed * verticalInput);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Garbage"))
        {
            score += 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);

        } 

        if (other.gameObject.CompareTag("Toxic"))
        {
            score -= 1;
            Debug.Log("Score: " + score);
            Destroy(other.gameObject);

        } 
    }
}
