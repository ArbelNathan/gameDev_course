using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class frog : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    
    // Start is called before the first frame update


    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 10000f;


    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        Vector3 movementVector = new Vector3(horizontal, vertical, 0) * speed ;
        transform.position += movementVector;
    }
}

