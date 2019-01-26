using UnityEngine;

public class ElectricityGenerator : MonoBehaviour
{
    public GameObject globalLight;
    public GameObject playerLight;

    void OnTriggerEnter2D(Collider2D other)
    {
        globalLight.SetActive(true);
        playerLight.SetActive(false);
    }
}
