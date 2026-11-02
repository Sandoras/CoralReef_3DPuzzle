using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(CharacterController))]

public class PlayerMovement : MonoBehaviour
{
    [Header("Setup")]
    [SerializeField] private CharacterController _controller;
    public bool IsOnGround;


    // Input setup
    private float xInput;
    private float zInput;
    private float _verticalVelocity;
    private Vector3 _movementDirection = Vector3.zero;

    [Header("Input Variables")]


    [SerializeField] private float _jumpHeight = 9;
    public float MovementSpeed = 5.5f;

    [SerializeField] private float currentMoveSpeed = 0;
    public float Gravity = -9.81f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentMoveSpeed = MovementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
        IsOnGround = _controller.isGrounded;

    }

    private void PlayerMove()
    {
        //SETUP
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");


        // JUMP
        if (!_controller.isGrounded && _verticalVelocity < 0f)
        {
            _verticalVelocity -= 2f;
        }

        if (_controller.isGrounded && Input.GetButtonDown("Jump"))
        {
            _verticalVelocity = Mathf.Sqrt(_jumpHeight * -2f * Gravity);
        }

        _verticalVelocity += Gravity * Time.deltaTime;

        _movementDirection.y = _verticalVelocity;


        //MOVE
        _movementDirection = transform.right * xInput + transform.forward * zInput;
        Vector3 movement = _movementDirection * MovementSpeed * Time.deltaTime;

        _controller.Move(movement);

    }
}
