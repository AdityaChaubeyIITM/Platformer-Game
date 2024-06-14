using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class joywali : MonoBehaviour
{
    // Start is called before the first frame update
    protected Joystick joystick;
    protected joybut joybutton;
    protected bool jump;
    void Start()
    {
        joystick = FindObjectOfType<Joystick>();
        joybutton = FindObjectOfType<joybut>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        var rb = GetComponent<Rigidbody>();
        rb.isKinematic = false;
        rb.velocity = new Vector3 (joystick.Horizontal * 5f, rb.velocity.y, joystick.Vertical * 5f );

        if (!jump && joybutton.Pressed){
            jump = true;
            rb.velocity += Vector3.up * 5f;
        }
        if (jump && !joybutton.Pressed){
            jump = false;

        }
    }
}
