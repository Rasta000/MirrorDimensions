using UnityEngine;

public class playerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D body;
    private bool grounded;
    private BoxCollider2D boxCollider;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        body.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, body.velocity.y); 

        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }
        
    }

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {

        }
    }

    private bool isGrounded()
    {
        return false;
    }
}
