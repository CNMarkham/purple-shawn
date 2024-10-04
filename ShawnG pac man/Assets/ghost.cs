using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Movement
{
   public GameObject body;
   public GameObject eyes;
   public GameObject blue;
  public  GameObject white;
   public bool frightend;
  public  bool atHome;
  public  float homeDuration;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();
        
        if (node != null)
        {
            int index = Random.Range(0, node.availableDirections.Count);

            if (node.availableDirections[index] == -direction)
            {
                index += 1;

                if (index == node.availableDirections.Count)
                {
                    index = 0;
                }
            }

            SetDirection(node.availableDirections[index]);
        }
    }

    override protected void ChildUpdate()
    {

    }

    private void LeaveHome()
    {
        transform.position = new Vector3(0, 2.5f, -1f);
        direction = new Vector2(-1, 0);
        atHome = false;
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightend = false;
        Invoke("LeaveHome", homeDuration);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (atHome && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SetDirection(-direction);
        }
    }
}
