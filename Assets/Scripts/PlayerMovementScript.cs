using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovementScript : MonoBehaviour
{
    float moveForward;
    float moveSide;
    float moveUp;

    bool isGrounded;

    public float walkSpeed = 5f;
    float currentSpeed;
    public float jumpSpeed = 5f;
    Rigidbody rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        currentSpeed = walkSpeed;

        moveForward = Input.GetAxis("Vertical") * currentSpeed;
        moveSide = Input.GetAxis("Horizontal") *currentSpeed;
        moveUp = Input.GetAxis("Jump") * currentSpeed;
        //if (SceneManager.GetActiveScene().name == "CubeZombieGerald")
           // {
               //audioPlayBetween.instance.GetComponent<AudioSource>().Pause();
            //}
    }
    
    private void FixedUpdate()
    {
        //Jump
        if(isGrounded && moveUp != 0)
        {
            rig.AddForce(transform.up * moveUp, ForceMode.VelocityChange);
            isGrounded = false;
            Debug.Log("Jumping");
        }

        rig.velocity = (transform.forward * moveForward) + (transform.right * moveSide) + (transform.up * rig.velocity.y);
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Ground Collision
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            Debug.Log("Ground");
        }

    }
}
