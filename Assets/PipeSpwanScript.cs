using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpwanScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate=3 ;
    private float timer = 0;
    public float heightoffset = 9;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer< spawnRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightoffset;
        float highestPoint = transform.position.y + heightoffset;

        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint,highestPoint),-1), transform.rotation);
    }
}
