using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public AudioClip scoreSound; // Sound clip for scoring
    private AudioSource audioSource;

    private void Start()
    {
        // Get the AudioSource component attached to the game object
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayScoreSound()
    {
        // Play the score sound
        audioSource.PlayOneShot(scoreSound);
    }
}
