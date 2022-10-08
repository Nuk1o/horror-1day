using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class person_controller : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] private float Speed = 10;

    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundMask;
    [SerializeField] private float Gravity = -9.8f;
    [SerializeField] private float GroundDistans = 0.4f;

    Vector3 velocity;
    bool isGrounded;

    [SerializeField] private float JumpH = 3;

    void Start()
    {
        
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * Speed * Time.deltaTime);

        isGrounded = Physics.CheckSphere(groundCheck.position, GroundDistans, groundMask);
        if(isGrounded == true && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded == true)
        {
            velocity.y = Mathf.Sqrt(JumpH * -2f * Gravity);
        }
        
        if(Input.GetKey(KeyCode.LeftControl))
        {
            controller.height = 1.2f;            
        }
        else
        {
            controller.height = 1.8f;
        }

        if(Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Start");
            Cursor.lockState = CursorLockMode.Confined;
        }

    }
}
