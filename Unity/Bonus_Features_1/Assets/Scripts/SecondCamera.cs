using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondCamera : MonoBehaviour
{
    public GameObject Camera;
    public GameObject secondCamera;
    private Vector3 offset = new Vector3(0, 3, 0);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public GameObject player;
    // Update is called once per frame
    void LateUpdate()
    {
        
        if (Input.GetKeyDown("space"))
        {
            Camera.SetActive(true);
            secondCamera.SetActive(false);
        }
        transform.position = player.transform.position + offset;
    }
}
