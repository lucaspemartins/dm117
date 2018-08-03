using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdController : MonoBehaviour {

    //properties 
    
    [Tooltip("Força do vôo do pássaro")]
    public float keyForce = 200f; //fly force

    private bool isDead = false; // flag to control when bird die

    private Rigidbody2D rigidBodyBird; // holds the bird's rigid body 

    private Animator animatorBird; // holds the animator from bird

	// Use this for initialization
	void Start () {

        //get the rigid body from bird , because it costs a lot in runtime , then we've made it on start of the game
        rigidBodyBird = GetComponent<Rigidbody2D>();

        //the same reason for the second component 
        animatorBird = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {

        //when the bird is not dead , the actions can be executed
        if (!isDead){

            //when we hiting up arrow key the bird fly 
            if (Input.GetKeyDown(KeyCode.UpArrow)){

                //preview some inconssitent behaviour 
                rigidBodyBird.velocity = Vector2.zero;

                //set the force to x scale and 0 to y scale 
                rigidBodyBird.AddForce(new Vector2(0, keyForce));

                //set the Flap animation using Flap trigger
                animatorBird.SetTrigger("Flap");
            }
        }
		
	}

    private void OnCollisionEnter2D(Collision2D collision){

        //set the flag to true , means the bird is dead
        isDead = true;

        //set the animator to die bird 
        animatorBird.SetTrigger("Die");
    }
}
