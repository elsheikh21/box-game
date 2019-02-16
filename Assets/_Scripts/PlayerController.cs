using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class PlayerController :MonoBehaviour {

    public float speed;
    private Rigidbody2D rb2d;
    private bool isDead;
    private bool isWin;

    void Start() {
        isWin = false;
        isDead = false;
        rb2d = GetComponent<Rigidbody2D>();
    }

    public void Kill() {
        isDead = true;
        GameController.instance.Kill();
    }

    public void Win() {
        isWin = true;
        GameController.instance.Win();
    }

    void Update() {
        if( isDead == false && isWin == false) {
            float moveHorizontal = Input.GetAxis( "Horizontal" );
            float moveVertical = Input.GetAxis( "Vertical" );
            Vector2 movement = new Vector2( moveHorizontal, moveVertical );
            rb2d.AddForce( movement * speed );
        }
    }
}
/*
Vector2 playerPosition = transform.position;
if(playerPosition)
transform.position = pos;
Debug.Log( pos );

anim.SetTrigger( "GameOver" );

public float rightBound;
public float leftBound;
public float topBound;
public float bottomBound;

private Vector2 pos;
private Transform target;

target = GameObject.FindWithTag( "Player" ).transform;

void OnCollisionEnter2D(Collision2D coll) {
isDead = true;
}
*/