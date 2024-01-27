using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 10f;
    [SerializeField] private GameObject pipe_0;
    [SerializeField] private GameObject pipe_1;
    [SerializeField] private GameObject pipe_2;
    private GameObject pipe_ex;

    private float timer;
    
    void Start()
    {
        SpawnPipe();
    }

    private void Update()
    {
        if(timer>maxTime)
        {
            SpawnPipe();
            timer = 0;
        }
        timer += Time.deltaTime;
    }

    private void SpawnPipe()
    {
        Vector3 spawnPos = transform.position + new Vector3(0, 0);
        int x = Random.Range(0,3);
        Debug.Log(x);

        if(x==0)
        {
            pipe_ex = pipe_0; 
        }
        else if(x==1) 
        {
            pipe_ex = pipe_1;
        }
        else if(x==2)
        {
            pipe_ex = pipe_2;
        }

        GameObject pipe = Instantiate(pipe_ex, spawnPos, Quaternion.identity);

        Destroy(pipe,20f);
    }
}
