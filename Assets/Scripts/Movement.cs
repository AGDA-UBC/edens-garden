using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rg;

    public float speed = 80.0f;
    public float gravity = -9.8f;
    private GameObject player;

    private CharacterController characterController;

    private void Start()
    {
        rg = GetComponent<Rigidbody>();
        characterController = GetComponent<CharacterController>();
        player = gameObject;
    }

    // Update is called once per frame
    void Update () {
        float deltaX = Input.GetAxis("Horizontal")*speed;
        float deltzaZ = Input.GetAxis("Vertical") * speed;

        Vector3 movement = new Vector3(deltaX, 0, deltzaZ);
        movement = transform.TransformDirection(movement);
        movement *= speed;
        //movement = Vector3.ClampMagnitude(movement, speed);


        movement.y -= gravity;
        movement *= Time.deltaTime;

        characterController.Move(movement * Time.deltaTime);

     
		
	}
}
