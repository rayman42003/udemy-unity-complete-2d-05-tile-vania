using UnityEngine;

public class Flippable : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private SpriteRenderer spriteRenderer;

    private void Start() {
        _rigidbody = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update() {
        float xVelocity = _rigidbody.velocity.x;
        if (Mathf.Abs(xVelocity) > Mathf.Epsilon) {
            //transform.localScale = new Vector2(Mathf.Sign(xVelocity), 1f);
            spriteRenderer.flipX = xVelocity < 0;
        }
    }
}
