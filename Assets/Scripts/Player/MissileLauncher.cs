using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject missilePrefab;
    public PlayerStatus status; // 인스펙터에서 직접 할당
    public float launchSpeed = 10.0f;

    // 버튼에서 호출할 발사 함수
    public void FireMissile()
    {
        if (status != null)
        {
            bool success = status.ConsumeMp(10);
            if (success)
            {
                Debug.Log("MP 감소 성공! 현재 MP: " + status.CurrentMp);
                GameObject missile = Instantiate(missilePrefab, transform.position, transform.rotation);
                Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);
            }
            else
            {
                Debug.Log("MP 부족! 현재 MP: " + status.CurrentMp);
            }
        }
        else
        {
            Debug.LogWarning("status가 null입니다! 인스펙터에서 PlayerStatus를 연결했는지 확인하세요.");
        }

    }
}
