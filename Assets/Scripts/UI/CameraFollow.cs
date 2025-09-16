using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;        // 따라갈 플레이어
    public Vector3 offset = new Vector3(0, 0, -10); // 카메라와 플레이어 사이 거리

    void LateUpdate()
    {
        if (player != null)
        {
            // 카메라 위치를 플레이어 위치 + 오프셋으로 이동
            transform.position = player.position + offset;
        }
    }
}
