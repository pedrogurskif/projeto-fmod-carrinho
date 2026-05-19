using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 75f;
    public InputActionAsset inputActions;
    public InputAction moveAction;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    
    void Update()
    {
        float horizontalInput = moveAction.ReadValue<Vector2>().x;
        float verticalInput = moveAction.ReadValue<Vector2>().y;
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
