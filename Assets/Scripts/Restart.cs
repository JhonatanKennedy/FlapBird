﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour{

    private void Start()
    {
        Time.timeScale = 1;
    }


    public void restart()
    {
        SceneManager.LoadScene(0);
    }
}
