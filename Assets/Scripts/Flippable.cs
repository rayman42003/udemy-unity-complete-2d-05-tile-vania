using UnityEngine;

public class Flippable : MonoBehaviour
{
    private static readonly float FLIP_EPSILON = 0.0001f;
    private Rigidbody2D _rigidbody;
    private SpriteRenderer spriteRenderer;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        float xVelocity = _rigidbody.velocity.x;
        if (Mathf.Abs(xVelocity) > FLIP_EPSILON) {
            spriteRenderer.flipX = xVelocity < 0;
        }
    }
}
