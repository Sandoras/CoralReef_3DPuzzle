using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    //INPUT SETUP
    // private float _mouseX;
    // private float _mouseY;

    private Camera _mainCamera;

    //VARIABLE SETUP
    [SerializeField] private float _mouseSpeed = 5;

    private float _xRotation;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _mainCamera = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;


    }

    // Update is called once per frame
    void Update()
    {
        float _mouseX = Input.GetAxis("Mouse X") * _mouseSpeed;

        float _mouseY = Input.GetAxis("Mouse Y") * _mouseSpeed;

        // X ROTATION
        _xRotation -= _mouseY;
        _xRotation = Mathf.Clamp(_xRotation, -90f, 90f);

        _mainCamera.transform.localRotation = Quaternion.Euler(_xRotation, 0, 0);

        transform.Rotate(Vector3.up * _mouseX);

    }
}
