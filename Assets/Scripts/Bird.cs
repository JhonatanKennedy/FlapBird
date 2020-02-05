using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bird : MonoBehaviour{

    private Rigidbody2D rigidbody;
    public GameObject GameOver;
    public float speed = 1f;
    public int counter = 0;
    public Text score;

    void Start(){
        Time.timeScale = 0;
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            rigidbody.velocity = Vector2.up * speed;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision){
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

    

    private void OnTriggerEnter2D(Collider2D collision){
        counter++;
        score.text = counter.ToString();
    }


}
