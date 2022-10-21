using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 10.0f;
    // public float turnSpeed = 25.0f;

    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(forwardInput * speed * Time.deltaTime * Vector3.forward);
        transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        // transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
