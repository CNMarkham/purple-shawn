using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerpellet : pellet
{
    protected override void Eat()
    {
        base.Eat();

        GameObject[] ghost = GameObject.FindGameObjectsWithTag("Ghost");
    }
}
