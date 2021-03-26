using UnityEngine;

public class Player : MonoBehaviour
{
    private static readonly float FLIP_EPSILON = 0.0001f;
    private Animator animator;
    private Rigidbody2D _rigidbody;

    private void Start() {
        animator = GetComponent<Animator>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        float xVelocity = _rigidbody.velocity.x;
        animator.SetBool("Running", Mathf.Abs(xVelocity) > FLIP_EPSILON);
    }
}
