using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRigidBody;
    public float jumForce = 10;
    public float gravityModifier;
    public bool isOnGround = true;
    void Start()
    {
        playerRigidBody = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround){
            playerRigidBody.AddForce(Vector3.up * jumForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    private void OnCollisionEnter(Collision collision){
        isOnGround = true;
    }
}
