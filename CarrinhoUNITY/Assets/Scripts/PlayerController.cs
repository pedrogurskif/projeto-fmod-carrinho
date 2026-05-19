using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 75f;
    [SerializeField] private InputActionAsset inputActions;
    private InputAction moveAction;
    private Vector2 playerInput;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
    }
    
    void Update()
    {
        playerInput = moveAction.ReadValue<Vector2>();
        transform.Translate(Vector3.forward * Time.deltaTime * speed * playerInput.y);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * playerInput.x);
    }
}
