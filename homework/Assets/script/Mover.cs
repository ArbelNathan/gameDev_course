using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [Tooltip("The velocity of the object, in meters per second")] [SerializeField] float speed=10f;
    // Start is called before the first frame update
    void Start()
    {
       Transform t =  GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + speed, transform.position.y, transform.position.z);
        if ((Mathf.Abs(transform.position.x) < -400f) && ((transform.position.x) < -200f) && (speed > 0f))
            speed = 10f;
        else if ((Mathf.Abs(transform.position.x) > -200f) && ((transform.position.x) < 2000f) && (speed > 0f))
            speed = 20f;
        else if ((Mathf.Abs(transform.position.x) > 2000f) && ((transform.position.x) < 4000f) && (speed > 0f))
            speed = 30f;
        else if ((Mathf.Abs(transform.position.x) > 4000f) && ((transform.position.x) < 6000f) && (speed > 0f))
            speed = 20f;
        else if ((Mathf.Abs(transform.position.x) > 6000f) && ((transform.position.x) > 4000f) && (speed > 0f))
            speed = -10f;
        else if ((Mathf.Abs(transform.position.x) < 6000f) && ((transform.position.x) > 4000f) && (speed < 0f))
            speed = -20f;
        else if ((Mathf.Abs(transform.position.x) < 4000f) && ((transform.position.x) > 2000f) && (speed < 0f))
            speed = -30f;
        else if ((Mathf.Abs(transform.position.x) < 2000f) && ((transform.position.x) > 0f) && (speed < 0f))
            speed = -10f;
        else if ((Mathf.Abs(transform.position.x) < 2000f) && ((transform.position.x) < 0f) && (speed < 0f))
            speed = 10f;



    }
}
