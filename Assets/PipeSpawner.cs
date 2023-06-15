using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float _timer = 0;
    public float hightOffset = 10;

    private void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (_timer < spawnRate)
        {
            _timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            _timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowetPoint = transform.position.y - hightOffset;
        float highestPoint = transform.position.y + hightOffset;
        
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowetPoint,highestPoint), 0), transform.rotation);

    }
}
