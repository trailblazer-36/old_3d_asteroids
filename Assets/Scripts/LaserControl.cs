using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserControl : MonoBehaviour
{
    public Rigidbody rb;
    public int speed = 200;
    public float angle = 10;
    public int lifetime = 10;
    public int damage = 1;
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        transform.Rotate(Vector3.up, Random.Range(angle, angle * -1));
        transform.Rotate(Vector3.right, Random.Range(angle, angle * -1));
        rb.AddForce(transform.forward * speed * -1, ForceMode.Impulse);
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
    }
}
