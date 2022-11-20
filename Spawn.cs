using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject[] spawnpos;

    private int rand;
    private int randPosition;
    public float StartTimeBtwSpawns;
    private float timeBtwSpawns;

    void Start()
    {
        timeBtwSpawns = StartTimeBtwSpawns;
    }

    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            rand = Random.Range(0, Enemy.Length);
            randPosition = Random.Range(0, spawnpos.Length);
            var enemy = Instantiate(Enemy[rand], spawnpos[randPosition].transform.position, Quaternion.identity);
            timeBtwSpawns = StartTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }

}