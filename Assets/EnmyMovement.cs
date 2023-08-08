using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnmyMovement : MonoBehaviour
{
    //define point A
    public Transform A;
    //define point B
    public Transform B;
    // Start is called before the first frame update
    void Start()
    {
        // look at point A once at the begining of the game
        transform.LookAt(A);
    }

    // Update is called once per frame
    private void Update()
    {
        //going forared all the time
        transform.Translate(Vector3.forward * 3 * Time.deltaTime);
    }
    //on trigger work when ever the object go throw trigger collider 
    private void OnTriggerEnter(Collider other)
    {
        //if the enemy rich to A it will look at B
        if (other.gameObject.name == "A")
        {
            transform.LookAt(B);
        }
        //if the enemy rich to B it will look at A
        else if (other.gameObject.name == "B")
        {
            transform.LookAt(A);
        }
    }
}