using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public scoreboard HS;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        BumperPoints score = collision.collider.GetComponent<BumperPoints>();
        Debug.Log("Score is " + score._score);
        HS._highscore += score._score; 

    }

    }
