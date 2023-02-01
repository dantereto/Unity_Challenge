using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public string inputID;

    public GameObject secondCamera;
    private float speed = 20;
    public float turnSpeed;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal" + inputID);
        forwardInput = Input.GetAxis("Vertical" +inputID);
         // Move the vehicle forward
         transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
         transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
