using UnityEngine;

public class MissileLauncher : MonoBehaviour
{
    public GameObject missilePrefab;
    public float launchSpeed = 10.0f;

    // 버튼에서 호출할 발사 함수
    public void FireMissile()
    {
        Debug.Log("발사");
        GameObject missile = Instantiate(missilePrefab, transform.position, transform.rotation);
        Rigidbody2D rb = missile.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * launchSpeed, ForceMode2D.Impulse);
    }
}
