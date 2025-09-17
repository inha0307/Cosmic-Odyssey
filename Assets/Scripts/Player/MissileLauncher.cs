using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject missilePrefab;
    public PlayerStatus status; // �ν����Ϳ��� ���� �Ҵ�
    public float launchSpeed = 10.0f;

    // ��ư���� ȣ���� �߻� �Լ�
    public void FireMissile()
    {
        if (status != null)
        {
            bool success = status.ConsumeMp(10);
            if (success)
            {
                Debug.Log("MP ���� ����! ���� MP: " + status.CurrentMp);
                GameObject missile = Instantiate(missilePrefab, transform.position, transform.rotation);
                Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
                rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);
            }
            else
            {
                Debug.Log("MP ����! ���� MP: " + status.CurrentMp);
            }
        }
        else
        {
            Debug.LogWarning("status�� null�Դϴ�! �ν����Ϳ��� PlayerStatus�� �����ߴ��� Ȯ���ϼ���.");
        }

    }
}
