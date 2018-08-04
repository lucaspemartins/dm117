using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class column : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.GetComponent<birdController>() != null)
        {
            //If the bird hits the trigger collider in between the columns then
            //tell the game control that the bird scored.
            gameController.gameControllerInstance.BirdScore();
        }
    }
}
