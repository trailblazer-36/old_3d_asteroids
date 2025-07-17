using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipController : MonoBehaviour
{
    public HealthBar healthBar;
    public Rigidbody rb;

    public float torque = 5f;
    public float acceleration = 30f;
    public float MaxHealth = 100f;
    private float currentHealth;
    public float startingRegen = 0.5f;
    public float Drag;
    public float AngDrag;
    
    

    
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentHealth = MaxHealth;
        healthBar.SetMaxHealth(MaxHealth);
        rb.drag = Drag;
        rb.angularDrag = AngDrag;
        
}

    // Update is called once per frame
    void Update()
    {
        float rotateX = Input.GetAxis("Vertical");
        float rotateZ = Input.GetAxis("Horizontal");
        float rotateY = Input.GetAxis("Flip");
        float thrust = Input.GetAxis("Jump");

        rb.AddTorque(transform.right * torque * rotateX);
        rb.AddTorque(transform.forward * torque * rotateZ);
        rb.AddTorque(transform.up * torque/4 * rotateY);
        rb.AddForce(transform.up * acceleration * thrust);


        if (Input.GetButtonDown("Fire3"))
        {
            TakeDamage(20);
        }

        if (!Input.GetButton("Jump") && currentHealth < MaxHealth) //when not shooting & health is less than max, heal the player
        {
            RegenHealth(startingRegen);
        }

        if (Input.GetButton("Fire2")) 
        {
            rb.drag = 0;
            rb.angularDrag = AngDrag * 2;
        } else
        {
            rb.drag = Drag;
            rb.angularDrag = AngDrag;
        }
        
    }

    void TakeDamage(float damage) //takes damage
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void RegenHealth(float regen) //regenerates health
    {
        currentHealth += regen;
        healthBar.SetHealth(currentHealth);
    }
}
