using UnityEngine;

public class AutoDoor : MonoBehaviour
{
    public GameObject door;
    public AudioClip doorOpenSound;
    public AudioClip doorCloseSound;
    
    Animator doorAnimator;
    AudioSource doorAudioSource;
    
    void Start()
    {
        doorAnimator = door.GetComponent<Animator>();
        doorAudioSource = door.GetComponent<AudioSource>();
    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.SetBool("Opened", true);
            doorAudioSource.clip = doorOpenSound;
            doorAudioSource.Play();
        }
    }
    
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimator.SetBool("Opened", false);
            doorAudioSource.clip = doorCloseSound;
            doorAudioSource.Play();
        }
    }
}
