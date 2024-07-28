using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rockPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-8, 8), Random.Range(-8,8), 0f);
        Instantiate(rockPrefab, Vector3.zero, Quaternion.identity);
    }


}
