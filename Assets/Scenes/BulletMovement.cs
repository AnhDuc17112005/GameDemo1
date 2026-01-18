using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    public float speed = 12f;

    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
