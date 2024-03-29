using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipMovement : MonoBehaviour
{
    // public bool throttle => Input.GetKey(KeyCode.Space);

    public float zRotationSpeed,
        zMaxRotation,
        xRotationSpeed,
        xMaxRotation;

    private Vector3 PlayerMovementInput;
    private Vector3 m_EulerAngleVelocity;

    [SerializeField]
    private Rigidbody PlayerBody;

    [SerializeField]
    private float Speed;

    [SerializeField]
    private float Sensitivity;

    // enginePower

    private float zAngle = 0,
        xAngle = 0;

    public float xRange = 20;
    public float yRange = 20;

    // private void Start()
    // {
    //     m_EulerAngleVelocity = new Vector3(100, 0, 100);
    // }

    private void Update()
    {
        // For Cursor Movement

        // Cursor.visible = false;
        // Cursor.lockState = CursorLockMode.Locked;
        // float h = Input.GetAxis("Mouse X");
        // float v = Input.GetAxis("Mouse Y");
        // PlayerBody.transform.Translate(h * Speed, v * Speed, 0);

        // For Key Movement

        PlayerMovementInput = new Vector3(
            Input.GetAxis("Horizontal"),
            Input.GetAxis("Vertical"),
            0f
        );

        MovePlayer();

        if (PlayerBody.transform.position.x > xRange)
        {
            PlayerBody.transform.position = new Vector3(
                xRange,
                PlayerBody.transform.position.y,
                PlayerBody.transform.position.z
            );
        }
        if (PlayerBody.transform.position.x < -xRange)
        {
            PlayerBody.transform.position = new Vector3(
                -xRange,
                PlayerBody.transform.position.y,
                PlayerBody.transform.position.z
            );
        }
        if (PlayerBody.transform.position.y > yRange)
        {
            PlayerBody.transform.position = new Vector3(
                PlayerBody.transform.position.x,
                yRange,
                PlayerBody.transform.position.z
            );
        }
        if (PlayerBody.transform.position.y < -4)
        {
            PlayerBody.transform.position = new Vector3(
                PlayerBody.transform.position.x,
                -4,
                PlayerBody.transform.position.z
            );
        }
    }

    private void MovePlayer()
    {
        Vector3 MoveVector = transform.TransformDirection(PlayerMovementInput) * Speed;
        PlayerBody.velocity = new Vector3(MoveVector.x, MoveVector.y, PlayerBody.velocity.z);
        // float targetZRotation = Mathf.Clamp(
        //     Input.GetAxis("Horizontal") * zRotationSpeed * Time.deltaTime,
        //     -zMaxRotation,
        //     zMaxRotation
        // );
        // float targetXRotation = Mathf.Clamp(
        //     Input.GetAxis("Vertical") * xRotationSpeed * Time.deltaTime,
        //     -xMaxRotation,
        //     xMaxRotation
        // );

        // zAngle = Mathf.Lerp(zAngle, targetZRotation, Time.deltaTime);
        // xAngle = Mathf.Lerp(xAngle, targetXRotation, Time.deltaTime);

        // zAngle = targetZRotation;
        // xAngle = targetXRotation;

        // // Apply rotation
        // transform.rotation = Quaternion.Euler(-xAngle, 0, -zAngle);
    }

    // private void FixedUpdate()
    // {
    //     Quaternion deltaRotation = Quaternion.Euler(m_EulerAngleVelocity * Time.fixedDeltaTime);
    //     PlayerBody.MoveRotation(PlayerBody.rotation * deltaRotation);
    // }
}
