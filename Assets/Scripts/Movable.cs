using UnityEngine;
using UnityEngine.InputSystem;

public class Movable : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed = 50f;

    private float currXSpeed = 0f;
    private Rigidbody2D _rigidbody;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        _rigidbody.velocity = new Vector2(currXSpeed * moveSpeed, _rigidbody.velocity.y);
    }

    public void setMoveSpeed(InputAction.CallbackContext ctx) {
        Debug.Log($"called: {ctx.ReadValue<Vector2>().ToString()}");
        currXSpeed = ctx.ReadValue<Vector2>().x;
    }
}
