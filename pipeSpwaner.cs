using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpwaner : MonoBehaviour
{
    //public float maxTime = 1;
    //public float timer = 0;
    public GameObject Pipe;
    public float limit;

    private float lastSpawnTime = Mathf.NegativeInfinity;
    private float spawnDelay = 2f;

    //private int currentlySpawned = 0;

    //private int maxSpawn =0;
    // Start is called before the first frame update
    void Start()
    {
        //GameObject newPipe = Instantiate(Pipe);
        //newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-limit,limit),0); 
    }

    // Update is called once per frame
    void Update()
    {
        checkSpawnerTime();
        /*if(timer>maxTime)
        {
                GameObject newPipe = Instantiate(Pipe);
                newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-limit,limit),0);
                Destroy(newPipe,30);
                timer=0;
        }
        timer += Time.deltaTime;*/
        
    }

    private void checkSpawnerTime()
    {
        if(Time.timeSinceLevelLoad > lastSpawnTime + spawnDelay)//&& (currentlySpawned < maxSpawn))
        {
            spawnPipe();
        }
    }

    private void spawnPipe()
    {
            GameObject newPipe = Instantiate(Pipe);
            newPipe.transform.position = transform.position + new Vector3(0,Random.Range(-limit,limit),0);
            Destroy(newPipe,30);
            lastSpawnTime = Time.timeSinceLevelLoad;
    }
}
