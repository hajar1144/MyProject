using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyy : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name== "Enimy")
        {
           
            Destroy(collision.gameObject);
        }
    }

}
