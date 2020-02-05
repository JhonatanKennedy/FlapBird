﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnP : MonoBehaviour{

    public GameObject pipe;
    public float height;
    public float maxTime;
    public float timer = 0f;


    void Start(){
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }


    void Update(){

        if(timer> maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 5f);
            timer = 0f;
        }
        timer += Time.deltaTime;
        
    }
}
