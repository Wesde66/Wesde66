using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Pig;
    Vector2 SpawnPoint = new Vector2(25, 0);
    public float DelayTime = 1;
    public float RepeatRate = 1;
    public Transform SpawnPointLocation;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPig", DelayTime, RepeatRate);
        SpawnPoint = SpawnPointLocation.position;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnPig()
    {
        Instantiate(Pig, SpawnPoint, Pig.transform.rotation);
        
    }

   
    
}
