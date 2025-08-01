using System.Runtime.CompilerServices;
using UnityEngine;

//1)이 스크립트를 사용하기 위해서는 Rigidbody 컴포넌트가 요구됩니다.
[RequireComponent(typeof(Rigidbody))]


public class PlayerMovement : MonoBehaviour
{
    public float speed;
  
    public float jp;

    public LayerMask ground;
   

    
    private Rigidbody rb;
    
    private bool isGrounded;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var x = Input.GetAxis("Horizontal");
        var z = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(x, 0, z);

        Vector3 velocity = dir * speed;

        rb.linearVelocity = velocity;

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jp, ForceMode.Impulse);
        }
    }
     
        private bool IsGrounded()
            { 
    

        return Physics.Raycast(transform.position, Vector3.down, 1.0f, ground);
    }
        
 }




