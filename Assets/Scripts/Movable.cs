using UnityEngine;
using UnityEngine.InputSystem;

public class Movable : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 5f;

    [SerializeField]
    private float jumpSpeed = 50f;

    private float currXSpeed = 0f;
    private Rigidbody2D _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        _rigidbody.velocity = new Vector2(currXSpeed * moveSpeed, _rigidbody.velocity.y);
    }

    public void setMoveSpeed(InputAction.CallbackContext ctx) {
        currXSpeed = ctx.ReadValue<Vector2>().x;
    }

    public void jump(InputAction.CallbackContext ctx) {
        if (ctx.started) {
            Vector2 verticalSpeed = new Vector2(0f, jumpSpeed);
            _rigidbody.velocity += verticalSpeed;
        }
    }
}
