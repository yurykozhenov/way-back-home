using UnityEngine;

public class GravityModule : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        Physics2D.gravity = new Vector2(0.0f, -30.0f);
    }
}
