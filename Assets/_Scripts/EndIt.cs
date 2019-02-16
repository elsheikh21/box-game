using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndIt : MonoBehaviour {
        
    PlayerController player = new PlayerController();

    void OnCollisionEnter2D(Collision2D coll) {
        if( coll.gameObject.tag == "RedBox" || coll.gameObject.tag == "Player" ) {
            Destroy( GameObject.Find( "Player" ) );
            Destroy( GameObject.Find( "RedBox1" ) );
            Destroy( GameObject.Find( "RedBox2" ) ); 
            Destroy( GameObject.Find( "RedBox3" ) ); 
            Destroy( GameObject.Find( "RedBox4" ) );
            Destroy( GameObject.Find( "RedBox5" ) );
            Destroy( GameObject.Find( "RedBox6" ) );
            player.Kill(); // to terminate the player
        }
    }
}