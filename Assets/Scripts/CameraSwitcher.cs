using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Player"))
        {
            Camera.main.transform.position = transform.position + new Vector3(0,0,-10);
        }
    }
}
