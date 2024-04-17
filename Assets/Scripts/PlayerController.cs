using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float verticalInput;
    private float horizontalInput;
    public float speed = 5.0f;
    public GameObject trashPrefab;
    public GameObject projectilePrefab;
    public int score;
    Rigidbody2D rigidbody2d;
     Vector2 lookDirection = new Vector2(1,0);
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

         Vector2 move = new Vector2(horizontalInput, verticalInput);
        
        if(!Mathf.Approximately(move.x, 0.0f) || !Mathf.Approximately(move.y, 0.0f))
        {
            lookDirection.Set(move.x, move.y);
            lookDirection.Normalize();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {

           GameObject projectile = Instantiate(projectilePrefab, rigidbody2d.position + lookDirection * 0.2f, Quaternion.identity);
           projectile.GetComponent<Projectile>().Launch(lookDirection, 1500);
        }

        if (transform.position.y > 7.4f)
        {
            transform.position = new Vector3(transform.position.x, 7.4f, transform.position.z);
        }
        if (transform.position.y < -6.669782f)
        {
            transform.position = new Vector3(transform.position.x, -6.669782f, transform.position.z);
        }

        
    }

     void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + speed * horizontalInput * Time.deltaTime;
        position.y = position.y + speed * verticalInput * Time.deltaTime;
        
        rigidbody2d.MovePosition(position);
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
    //void Launch()
   // {
        //GameObject projectileObject = Instantiate(projectilePrefab, rigidbody2d.position + Vector2.up * 0.5f, Quaternion.identity);

        
   // }

}
