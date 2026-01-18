using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float fireRate = 0.2f;   // 0.2s = 5 viên/giây
    public float bulletOffsetY = 1.2f;

    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        // Bắn khi giữ chuột trái
        if (Input.GetMouseButton(0) && timer >= fireRate)
        {
            Shoot();
            timer = 0f;
        }
    }

    void Shoot()
    {
        Vector3 spawnPos = transform.position + new Vector3(0f, bulletOffsetY, 0f);
        Instantiate(bulletPrefab, spawnPos, Quaternion.identity);
    }
}
