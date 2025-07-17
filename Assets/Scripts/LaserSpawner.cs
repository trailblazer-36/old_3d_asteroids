using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSpawner : MonoBehaviour
{
    public Transform laserPrefab;
    

    private float nextFire = 0.0f;
    public float rateOfFire = 0.1f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time > nextFire)
        {
            
            Instantiate(laserPrefab, transform.position, transform.rotation);
            nextFire = Time.time + rateOfFire;



        }
    }
}
