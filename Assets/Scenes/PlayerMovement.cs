using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float padding = 0.5f; // khoảng cách cách mép màn hình

    void Update()
    {
        // 1) Lấy vị trí chuột (screen -> world)
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        pos.z = 0f;

        // 2) Tính giới hạn theo camera
        Camera cam = Camera.main;
        float halfH = cam.orthographicSize;
        float halfW = halfH * cam.aspect;

        // 3) Khóa trong màn hình
        pos.x = Mathf.Clamp(pos.x, -halfW + padding, halfW - padding);
        pos.y = Mathf.Clamp(pos.y, -halfH + padding, halfH - padding);

        // 4) Gán vị trí
        transform.position = pos;
    }
}
