using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float horizontalmovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), -0.5f, Input.GetAxis("Vertical"));
        Rigidbody.velocity = Movement * 5;
        Vector3 direction = new Vector3(Rigidbody.velocity.x, 0, Rigidbody.velocity.z);
        Rigidbody.MoveRotation(Quaternion.LookRotation(direction));
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody.AddForce(0, 15, 0, ForceMode.Impulse);
        }
        anim.SetFloat("horizontalWalking", horizontalmovement);
        anim.SetFloat("verticalMovement", verticalMovement);
    }

}