using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLogger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start collisionlogger on "+this.name);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("you loss!" );
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Collider2D other = collision.collider;
        Debug.Log("you loss!!");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("you loss!!!");
    }
    private void OnCollisionEnter(Collision collision)
    {
        Collider other = collision.collider;
        Debug.Log("you loss!!!!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
