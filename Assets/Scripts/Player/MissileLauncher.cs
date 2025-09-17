using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject missilePrefab;
    public float launchSpeed = 10.0f;

    // ��ư���� ȣ���� �߻� �Լ�
    public void FireMissile()
    {
        Debug.Log("�߻�");
        GameObject missile = Instantiate(missilePrefab, transform.position, transform.rotation);
        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);
    }
}
