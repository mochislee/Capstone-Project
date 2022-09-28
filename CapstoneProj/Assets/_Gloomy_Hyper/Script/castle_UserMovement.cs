using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class castle_UserMovement : MonoBehaviour
{
     //VARIABLES
    [SerializeField] private float moveSpeed;
    [SerializeField] private float walkSpeed;
    [SerializeField] private float runSpeed;

    private Vector3 moveDirection;

    private Vector3 rotateDirection;

    private Vector3 targetAngles;

    private Vector3 velocity;

    [SerializeField] private bool isGrounded;
    [SerializeField] private float grounndCheckDistance;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float gravity;

    [SerializeField] private float jumpHeight;

    //REFERENCES
    private CharacterController controller;
    private Animator anim;
    private bool isJumping;
    private bool isLanding;

    
     public float smooth = 1f;
 
    private Quaternion targetRotation;

    // Start is called before the first frame update
    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        Move();
        
    }
   

    private void Move()
    {
        isGrounded = Physics.CheckSphere(transform.position, grounndCheckDistance, groundMask);

        if(isGrounded && velocity.y < 0){
            velocity.y = -2f;
        }        

        float moveZ = Input.GetAxis("Horizontal");
        float moveX = Input.GetAxis("Vertical");
        moveDirection = new Vector3(moveX, 0, moveZ);
        
//
       
        if(isGrounded)
        {
            anim.SetBool("isJumping", false);
            isJumping = false;
            // WALK
            if(moveDirection != Vector3.zero && !Input.GetKey(KeyCode.LeftShift))
            {
                Walk();
            } 
            // RUN
            else if(moveDirection != Vector3.zero && Input.GetKey(KeyCode.LeftShift))
            {
                Run();
                
            }

            // IDLE
            else if(moveDirection == Vector3.zero){
                Idle();
            }

            


            moveDirection *= moveSpeed;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                Jump();
            }

            
        }

        controller.Move(moveDirection * Time.deltaTime);
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
        
        
    }

    private void Idle() { anim.SetFloat("Speed", 0); }
    private void Walk() { moveSpeed = walkSpeed; anim.SetFloat("Speed", 0.5f); }
    private void Run()  { moveSpeed = runSpeed; anim.SetFloat("Speed", 1);}
    private void Jump() {
        velocity.y = Mathf.Sqrt(jumpHeight * -2 * gravity);
        anim.SetBool("isJumping", true);
        isJumping = true;
    }

    /*
    private void Rotate()
    {
        targetAngles = transform.eulerAngles + 80f * Vector3.up; 
        transform.eulerAngles = Vector3.Lerp(transform.eulerAngles, targetAngles, smooth * Time.deltaTime);
    }
   */
}
