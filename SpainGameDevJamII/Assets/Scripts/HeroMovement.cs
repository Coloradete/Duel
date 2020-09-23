using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroMovement : MonoBehaviour
{
    private PlayerControlls playerControlls;
    private InputAction movement, dash;

    private Vector3 movementDirection, lastNonZeroDirection;

    private bool isDashing;
    [SerializeField] private float dashVelocity, dashingTime, runSpeed;

    private Rigidbody rBody;
    private HeroStatus heroStatus;

    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private bool isRunning;
    private void Awake()
    {
        rBody = GetComponent<Rigidbody>();
        heroStatus = GetComponent<HeroStatus>();

        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        playerControlls = new PlayerControlls();
        dash = playerControlls.HeroController.Dash;
        dash.performed += DashPerformed;
        movement = playerControlls.HeroController.Movement;
        movement.performed += Movement_performed;
        movement.canceled += Movement_performed;
    }

    private void OnEnable()
    {
        playerControlls.Enable();
        movement.Enable();   
        dash.Enable();
    }

    private void OnDisable()
    {
        playerControlls.Disable();
        movement.Disable();
        dash.Disable();
    }
    private void Movement_performed(InputAction.CallbackContext obj)
    {
        lastNonZeroDirection = movementDirection;
        Vector2 readValue = obj.ReadValue<Vector2>();
        readValue.Normalize();
        movementDirection = new Vector3(readValue.x, 0f, readValue.y);
        Move();
    }

    private void Move()
    {
        if(!isDashing)
            rBody.velocity = movementDirection * runSpeed * Time.deltaTime;
        UpdateAnimation();
    }

    private void UpdateAnimation()
    {
        if (rBody.velocity.magnitude > 0.1f && !isRunning)
        {
            isRunning = true;
            animator.SetBool("IsRunning", true);
        }else if (rBody.velocity.magnitude <= 0.1f && isRunning)
        {
            isRunning = false;
            animator.SetBool("IsRunning", false);
        }
        if (rBody.velocity.x > 0f && !spriteRenderer.flipX)
            spriteRenderer.flipX = true;
        else if (rBody.velocity.x < 0f && spriteRenderer)
            spriteRenderer.flipX = false;
    }
    private void DashPerformed(InputAction.CallbackContext obj)
    {
        StartCoroutine(Dash());
    }
    private IEnumerator Dash()
    {
        if (!isDashing && movementDirection != Vector3.zero)
        {
            isDashing = true;
            Vector3 oldVelocity = rBody.velocity;
            rBody.velocity *= dashVelocity;
            yield return new WaitForSeconds(dashingTime);
            isDashing = false;
            rBody.velocity = oldVelocity;
        }
    }

    public Vector3 GetMovementDirection()
    {
        if (movementDirection == Vector3.zero)
            return lastNonZeroDirection;
        else
            return movementDirection;
    }
}
