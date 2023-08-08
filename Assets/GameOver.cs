using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//scene manager package
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    //on collision run when the object hit another one with non trigger rigidbody
    private void OnCollisionEnter(Collision other)
    {
        //check if the enemy hit the player not other objects
        if (other.gameObject.name == "Player")
        {
            //load game over scene from its number in the build settings
            SceneManager.LoadScene("GameOver");
        }

    }
    void Update()
    {

    }
}