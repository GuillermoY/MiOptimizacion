using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] float horsePower = 0;
    [SerializeField] float vel;
    [SerializeField] float rpm;
    const float velgir = 45f;
    float hinpt;
    float vinpt;
    private Rigidbody rb;

    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerT;
    [SerializeField] TextMeshProUGUI rpmT;

    [SerializeField] List<WheelCollider> wheels;
    [SerializeField] int wheelsOnGround;

    void Start()
    {
             rb = GetComponent<Rigidbody>();
             rb.centerOfMass = centerOfMass.transform.position;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        hinpt = Input.GetAxis("Horizontal");
        vinpt = Input.GetAxis("Vertical");
        if(IsOnGround())
        {
            rb.AddRelativeForce(Vector3.forward * horsePower * vinpt);
            transform.Rotate(Vector3.up, Time.deltaTime * velgir * hinpt);
            //transform.Translate(Vector3.forward * vinpt * Time.deltaTime * vel);

            vel = Mathf.RoundToInt(rb.velocity.magnitude * 2.237f); // Para kph, cambia 2.236 a 3.6
            speedometerT.SetText("Speed: " + vel + "mph");

            rpm = (vel % 30) * 40;
            rpmT.SetText("RPM: " + rpm);
        }
    }
    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in wheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if (wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
}

