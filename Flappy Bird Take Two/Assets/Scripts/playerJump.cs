using UnityEngine;
using UnityEngine.InputSystem;

public class playerJump : MonoBehaviour
{
    InputAction jumpAction;
    public float jumpPower;
    Rigidbody2D rb;

    void Start()
    {
        jumpAction = InputSystem.actions.FindAction("Jump");
        rb = GetComponent<Rigidbody2D>();

    } 
    // Update is called once per frame
    void Update()
    {
        if (jumpAction.triggered)
        {
            rb.linearVelocityY = jumpPower;
        }
    }
}
