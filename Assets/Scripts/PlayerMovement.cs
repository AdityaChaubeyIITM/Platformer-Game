using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody rb;
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground;
    [SerializeField] AudioSource Jumpsound;


    void Jump(){
            rb.velocity= new Vector3(rb.velocity.x,5f,rb.velocity.z);
            Jumpsound.Play();

        }
    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.CompareTag("head")){
            Destroy(collision.transform.parent.gameObject);
            Jump();
         }
    
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        

        rb.velocity = new Vector3(horizontalInput * 5f, rb.velocity.y , verticalInput * 5f);
        if (Input.GetButtonDown("Jump") && IsGrounded())
        {
            Jump();
        }

           
        bool IsGrounded ()
        {

            return Physics.CheckSphere(groundCheck.position, .1f, ground);

        }

    }
}
