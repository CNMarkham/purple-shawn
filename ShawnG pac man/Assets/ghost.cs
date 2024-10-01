using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Movement
{
    GameObject body;
    GameObject eyes;
    GameObject blue;
    GameObject white;
    bool frightend;
    bool atHome;
    float homeDuration;
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

    private void Awake()
    {
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightend = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (atHome && collision.gameObject.layer == LayerMask.NameToLayer("Obstacle"))
        {
            SetDirection(-direction);
        }
    }
}
