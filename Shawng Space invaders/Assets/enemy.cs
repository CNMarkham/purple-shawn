using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class enemy : MonoBehaviour


{
    private Animator animator;
    public float speed;
   static private Vector2 direction;
    //stactic is to let the objects all do the same thing at same time
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }

    // Update is called once per frame
    void Update()
  
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > 12f)
        {
            direction = Vector2.left;
            MoveDown();
        }

        if (transform.position.x < -12f)
        {
            direction = Vector2.right;
            MoveDown();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("death");
        Destroy(gameObject,1f);
        Destroy(collision.gameObject);
    }


    private void MoveDown()
    {
        foreach (enemy enemy in FindObjectsOfType(typeof(enemy)))
        {
            enemy.transform.Translate(Vector2.down *0.5f);
        }
    }
}


