using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "Enimy")
        {
            Debug.Log("hit");
            Destroy(collision.gameObject);
        }
    }

}
