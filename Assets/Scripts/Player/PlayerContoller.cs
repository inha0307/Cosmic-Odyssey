using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float accel = 5f;        // 가속도 크기
    public float maxSpeed = 10f;    // 최대 속도
    public float decel = 1f;        // 감속도 (움직이지 않을 때 초당 -1.0f)

    public VariableJoystick joy;
    Rigidbody2D rb;

    Vector2 velocity;  // 현재 속도

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        velocity = Vector2.zero;
    }

    private void FixedUpdate()
    {
        float horizontal = joy.Horizontal;
        float vertical = joy.Vertical;

        Vector2 inputDir = new Vector2(horizontal, vertical).normalized;

        if (inputDir.magnitude > 0)
        {
            // 입력이 있을 때 → 가속도 적용
            velocity += inputDir * accel * Time.fixedDeltaTime;

            // 최대 속도 제한
            velocity = Vector2.ClampMagnitude(velocity, maxSpeed);

            // 🚀 회전 추가: 입력 방향을 바라보도록
            float angle = Mathf.Atan2(inputDir.y, inputDir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = angle;  // Rigidbody2D 회전
        }
        else
        {
            // 입력 없을 때 → 감속
            if (velocity.magnitude > 0)
            {
                float newSpeed = velocity.magnitude - decel * Time.fixedDeltaTime;
                newSpeed = Mathf.Max(newSpeed, 0);
                velocity = velocity.normalized * newSpeed;
            }
        }

        // 위치 이동
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
    }
}
