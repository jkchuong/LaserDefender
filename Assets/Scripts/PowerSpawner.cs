using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerSpawner : MonoBehaviour
{
    [SerializeField] bool looping = false;
    [SerializeField] GameObject[] PowerUps;
    [SerializeField] float randomRange = 5f;
    [SerializeField] float delayBeforeSpawning = 20f;
    [SerializeField] float timeBetweenSpawning = 15f;

    
    IEnumerator Start()
    {

        yield return new WaitForSeconds(delayBeforeSpawning);
        do
        {
            yield return StartCoroutine(SpawnPowerUps());
        }
        while (looping);
    }
    
    private IEnumerator SpawnPowerUps()
    {
        Instantiate(PowerUps[UnityEngine.Random.Range(0, PowerUps.Length)], transform.position + (transform.right * RandomGen(randomRange)), Quaternion.identity);
        yield return new WaitForSeconds(timeBetweenSpawning);
    }

    private float RandomGen(float randomRange)
    {
        return UnityEngine.Random.Range(-randomRange, randomRange);
    }
}
