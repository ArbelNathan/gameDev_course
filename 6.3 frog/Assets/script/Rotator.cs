using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Tooltip("The velocity of the object, in meters per second")] [SerializeField] float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
       // Transform r = GetComponent<Transform>();
       // transform.rotation = new Vector(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 point = new Vector3(5, 0, 0);
        Vector3 axis = new Vector3(0, 0, 1);
        this.transform.RotateAround(point, axis, speed * Time.deltaTime); 
   

    }
}
