using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerpellet : Pellet
{
    protected override void Eat()
    {
        base.Eat();

        GameObject[] ghosts = GameObject.FindGameObjectsWithTag("Ghost");

        foreach(GameObject Ghost in ghosts)
        {
            Ghost.GetComponent<Ghost>().Frighten();
        }
    }
}
