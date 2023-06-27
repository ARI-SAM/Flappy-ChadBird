using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private ScoreManager scoreManager;

    private void Start()
    {
        // Get the ScoreManager component from the parent "middle" prefab
        scoreManager = GetComponentInParent<ScoreManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            // Player has passed through the middle of the pipe, trigger scoring logic
            scoreManager.PlayScoreSound();
            // Increase score logic...
        }
    }
}
