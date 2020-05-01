using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    [Tooltip("The velocity of the object, in meters per second")] [SerializeField] float speed = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(5, 0, 0);
        Vector3 axis = new Vector3(0, 1, 1);
        if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
            this.transform.RotateAround(point, axis, speed * Time.deltaTime);
            //transform.position = new Vector3(transform.position.x - speed, transform.position.y - speed, transform.position.z);
        }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
            this.transform.RotateAround(point, axis,-speed * Time.deltaTime);
            // transform.position = new Vector3(transform.position.x + speed, transform.position.y - speed, transform.position.z);
        }
           
            }
        
    
    // if (Input.geth(KeyCode.RightArrow))
    //   transform.position = new Vector3(transform.position.x + 10, transform.position.y - speed, transform.position.z);
    //  else if (Input.GetKeyDown(KeyCode.LeftArrow))
    //  transform.position = new Vector3(transform.position.x - 10, transform.position.y - speed, transform.position.z);

}

