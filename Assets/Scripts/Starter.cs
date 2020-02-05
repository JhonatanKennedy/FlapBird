using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Starter : MonoBehaviour
{

    public GameObject begin;


    public void moveOn(){
        Time.timeScale = 1;
        begin.SetActive(false);
    }
}
