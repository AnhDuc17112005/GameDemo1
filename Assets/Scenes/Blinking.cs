using UnityEngine;

public class Blinking : MonoBehaviour
{
    public float interval = 0.1f; // chỉnh tốc độ nhấp nháy
    private float t;
    private SpriteRenderer sr;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        t += Time.deltaTime;
        if (t >= interval)
        {
            sr.enabled = !sr.enabled;
            t = 0f;
        }
    }
}
