using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] float jumpForce = 5f;
    [SerializeField] float gravityMultiplier = 2f;
    [SerializeField] Transform groundCheck;  // Ajout du groundCheck

    private PlayerControls controls;
    private Vector2 moveInput;
    private Rigidbody rb;



    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        controls = new PlayerControls();
        controls.Player.Move.performed += ctx => moveInput = ctx.ReadValue<Vector2>();
        controls.Player.Jump.performed += _ => Jump();
    }

    private void Update()
    {
        Move();
        ApplyGravity();
    }

    private void Move()
    {
        Vector3 movement = new Vector3(moveInput.x, 0f, 0f);
        transform.Translate(movement * speed * Time.deltaTime);
    }

    private void Jump()
    {
        if (IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void ApplyGravity()
    {
        if (!IsGrounded())
        {
            // Applique une force vers le bas pour simuler la gravité seulement si le joueur n'est pas au sol
            rb.AddForce(Vector3.down * gravityMultiplier, ForceMode.Acceleration);
        }
    }

    private bool IsGrounded()
    {
        // Utilise un Raycast ou un SphereCast pour détecter si le joueur est au sol
        float raycastDistance = 0.5f; // Ajuste la distance du Raycast selon la taille de ton personnage
        Debug.DrawRay(groundCheck.position, Vector3.down * raycastDistance);
        return Physics.Raycast(groundCheck.position, Vector3.down, raycastDistance);
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
