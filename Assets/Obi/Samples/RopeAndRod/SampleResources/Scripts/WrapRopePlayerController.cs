using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody))]
public class WrapRopePlayerController : MonoBehaviour
{
    public float acceleration = 50;
    Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;

        // Determine movement direction:
        if (Keyboard.current[Key.W].IsPressed())
        {
            direction += Vector3.up * acceleration;
        }
        if (Keyboard.current[Key.A].IsPressed())
        {
            direction += Vector3.left * acceleration;
        }
        if (Keyboard.current[Key.S].IsPressed())
        {
            direction += Vector3.down * acceleration;
        }
        if (Keyboard.current[Key.D].IsPressed())
        {
            direction += Vector3.right * acceleration;
        }

        rb.AddForce(direction.normalized * acceleration, ForceMode.Acceleration);
    }

}
