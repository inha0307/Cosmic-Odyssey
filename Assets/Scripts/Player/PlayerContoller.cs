using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public VariableJoystick joy;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        float horizontal = joy.Horizontal;
        float vertical = joy.Vertical;

        Vector2 direction = new Vector2(horizontal, vertical).normalized;

        // MovePosition으로 부드럽게 이동
        Vector2 newPosition = rb.position + direction * speed * Time.fixedDeltaTime;
        rb.MovePosition(newPosition);

        Debug.Log($"[MovePosition] Input=({horizontal}, {vertical}), Dir={direction}, Pos={newPosition}");
    }
}
