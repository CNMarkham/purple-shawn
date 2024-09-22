using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Movement
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();
        
        if (node != null)
        {
            int index = Random.Range(0, node.availableDirections.Count);
            {
                index += 1;

                
            }

            SetDirection(node.availableDirections[index]);
        }
    }

    override protected void ChildUpdate()
    {

    }

}
