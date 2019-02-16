using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport : MonoBehaviour {

    PlayerController player = new PlayerController();
    private Rigidbody2D rb2d;
    
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();
    }
    
    void OnCollisionEnter2D(Collision2D coll) {
        bool flag1 = false;
        bool flag2 = false;
        bool flag3 = false;
        
        if( coll.gameObject.name == "RedBox1" || coll.gameObject.name == "RedBox2" ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                Destroy( GameObject.Find( "OrangeBox1" ) );
                if( coll.gameObject.name == "RedBox1" )
                    Destroy( GameObject.Find( "RedBox2" ) );
                else
                    Destroy( GameObject.Find( "RedBox1" ) );
                coll.gameObject.transform.position = GameObject.Find( "OrangeBox1" ).transform.position;
            } else {
                Destroy( GameObject.Find( "OrangeBox2" ) );
                if( coll.gameObject.name == "RedBox2" )
                    Destroy( GameObject.Find( "RedBox1" ) );
                else
                    Destroy( GameObject.Find( "RedBox2" ) );
                //GameObject.Find( "OrangeBox2" );
                coll.gameObject.transform.position = GameObject.Find( "OrangeBox2" ).transform.position;
            }
            flag1 = true;
        }

        if( coll.gameObject.name == "RedBox3" || coll.gameObject.name == "RedBox4" ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                if( coll.gameObject.name == "RedBox3" ) {
                    Destroy( GameObject.Find( "RedBox4" ) );
                } else {
                    Destroy( GameObject.Find( "RedBox3" ) );
                }
                Destroy( GameObject.Find( "OrangeBox3" ) );
                coll.gameObject.transform.position = GameObject.Find( "OrangeBox3" ).transform.position;
            } else {
                if( coll.gameObject.name == "RedBox4" ) {
                    Destroy( GameObject.Find( "RedBox3" ) );
                } else {
                    Destroy( GameObject.Find( "RedBox4" ) );
                }
                Destroy( GameObject.Find( "OrangeBox4" ) );
                coll.gameObject.transform.position = GameObject.Find( "OrangeBox4" ).transform.position;
            }
            flag2 = true;
        }
        
        if( coll.gameObject.name == "RedBox5" || coll.gameObject.name == "RedBox6" ) {
            if( Random.Range( 0, 2 ) < 1 ) {
                if( coll.gameObject.name == "RedBox5" ) {
                    Destroy( GameObject.Find( "RedBox6" ) );
                } else {
                    Destroy( GameObject.Find( "RedBox5" ) );
                }
                Destroy( GameObject.Find( "OrangeBox5" ) );
                coll.gameObject.transform.position = GameObject.Find( "OrangeBox5" ).transform.position;
            } else {
                if( coll.gameObject.name == "RedBox6" ) {
                    Destroy( GameObject.Find( "RedBox5" ) );
                } else {
                    Destroy( GameObject.Find( "RedBox6" ) );
                }
                Destroy( GameObject.Find( "OrangeBox6" ) );
                coll.gameObject.transform.position = GameObject.Find( "OrangeBox6" ).transform.position;
            }
            flag3 = true;
        }
        if( flag1 == true && flag2 == true && flag3 == true ) {
            Destroy( GameObject.Find( "Player" ) );
            Destroy( GameObject.Find( "RedBox1" ) );
            Destroy( GameObject.Find( "RedBox2" ) );
            Destroy( GameObject.Find( "RedBox3" ) );
            Destroy( GameObject.Find( "RedBox4" ) );
            Destroy( GameObject.Find( "RedBox5" ) );
            Destroy( GameObject.Find( "RedBox6" ) );
            player.Win();
        }
    }
}
