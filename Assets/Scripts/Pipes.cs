using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour{

    public float velocita = 1f;
    // Update is called once per frame
    void Update(){
        transform.position += Vector3.left * velocita * Time.deltaTime;
    }
}
