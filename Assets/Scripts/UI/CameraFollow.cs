using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;        // ���� �÷��̾�
    public Vector3 offset = new Vector3(0, 0, -10); // ī�޶�� �÷��̾� ���� �Ÿ�

    void LateUpdate()
    {
        if (player != null)
        {
            // ī�޶� ��ġ�� �÷��̾� ��ġ + ���������� �̵�
            transform.position = player.position + offset;
        }
    }
}
