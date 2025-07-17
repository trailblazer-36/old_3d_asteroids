using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public CharacterController controller;

    public float speed = 12f;
    public float rotateAngle = 360f;
    float smooth = 2.5f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotateOnX = Input.GetAxis("Horizontal") * rotateAngle;
        float rotateOnZ = Input.GetAxis("Vertical") * rotateAngle;
        float y = Input.GetAxis("Jump");

        //Quaternion target = Quaternion.Euler(rotateOnX, 0, rotateOnZ);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);



        Vector3 move = transform.up * y;
        controller.Move(move * speed * Time.deltaTime);


    }
}
