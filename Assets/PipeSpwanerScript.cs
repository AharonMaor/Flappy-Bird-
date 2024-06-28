using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpwanerScript : MonoBehaviour
{
    public GameObject Pipe;
    public float SpwanRate = 2;
    private float timer = 0;
    public float heightOfSpwaner= 10;
    // Start is called before the first frame update
    void Start()
    {
        Spwan();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < SpwanRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Spwan();
            timer = 0;
        }
        
    }

    void Spwan()
    {
        float lowestPoint = transform.position.y - heightOfSpwaner;
        float highetPoint = transform.position.y + heightOfSpwaner;
        Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highetPoint),0), transform.rotation);
    }
}
