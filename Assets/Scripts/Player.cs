using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    private static readonly float FLIP_EPSILON = 0.0001f;
    private Animator animator;
    private Rigidbody2D _rigidbody;
    private bool moveKeyPressed = false;

    private void Start() {
        animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float xVelocity = _rigidbody.velocity.x;
        animator.SetBool("Running", Mathf.Abs(xVelocity) > FLIP_EPSILON && moveKeyPressed);
    }

    public void onMoveKeyPressed(InputAction.CallbackContext ctx) {
        if (ctx.started) {
            moveKeyPressed = true;
        } else if (ctx.canceled) {
            moveKeyPressed = false;
        }
    }
}
