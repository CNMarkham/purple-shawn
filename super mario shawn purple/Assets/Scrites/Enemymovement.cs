using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemymovement : MonoBehaviour
{
    public float speed = 2f;
        public Vector2 direction = Vector2.left;
    private Rigidbody2D rb;
<<<<<<< Updated upstream:super mario shawn purple/Assets/Scrites/Enemymovement.cs
=======
    public float moveSpeed;

    private RaycastHit2D hit;
    public float jumpForce;
>>>>>>> Stashed changes:super mario shawn purple/Assets/PlayerMovement.cs
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

<<<<<<< Updated upstream:super mario shawn purple/Assets/Scrites/Enemymovement.cs
    private void OnBecameVisible()
    {
        rb.velocity = direction * speed;
=======
        rb.AddForce(Vector2.right * horizontal * moveSpeed * Time.deltaTime);

        Jump();
    }
    private void Jump()
    {
        hit = Physics2D.CircleCast(rb.position, 0.25f, Vector2.down, 0.375f, LayerMask.GetMask("Default"));
        if (hit.collider != null && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        }

>>>>>>> Stashed changes:super mario shawn purple/Assets/PlayerMovement.cs
    }
}
