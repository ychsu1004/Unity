using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float verticalRotationSpeed = 10.0f;
    public float horizontalRotationSpeed = 10.0f;
    public float speed = 5.0f;
    public float backAngleSpeed = 5.0f;
    public float verticalInput;
    public float horizontalInput;
    public float backInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Fire1");
        backInput = Input.GetAxis("Fire2");
        
        // move the plane forward at a constant rate
        //transform.Translate(Vector3.back * speed * verticalInput);

        // tilt the plane up/down based on up/down arrow keys
        //transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * horizontalInput);
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        transform.Rotate(Vector3.forward * backAngleSpeed * Time.deltaTime * backInput);
        transform.Rotate(Vector3.right * verticalRotationSpeed * Time.deltaTime * verticalInput);
        transform.Rotate(Vector3.up * horizontalRotationSpeed * Time.deltaTime * horizontalInput);
    }
}
