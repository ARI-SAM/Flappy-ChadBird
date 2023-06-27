using UnityEngine;

public class CloudMovement : MonoBehaviour
{
    public float speed = 2f; // Speed of the cloud movement
    public float spawnDistance = 10f; // Distance between each cloud spawn

    private float screenWidth; // Width of the screen
    private float cloudWidth; // Width of the cloud object
    private bool isOffScreen; // Flag indicating if the cloud is off the screen

    private void Start()
    {
        // Get the width of the screen
        screenWidth = Screen.width;

        // Get the width of the cloud object
        Renderer cloudRenderer = GetComponent<Renderer>();
        cloudWidth = cloudRenderer.bounds.size.x;

        // Set the initial cloud position
        ResetCloudPosition();
    }

    private void Update()
    {
        // Move the cloud horizontally
        transform.Translate(Vector3.right * speed * Time.deltaTime);

        // Check if the cloud is off the screen
        if (!isOffScreen && transform.position.x > screenWidth)
        {
            isOffScreen = true;
            ResetCloudPosition();
        }
    }

    private void ResetCloudPosition()
    {
        // Calculate the new cloud position
        float newX = -screenWidth - cloudWidth - spawnDistance;
        float newY = Random.Range(-Screen.height / 2f, Screen.height / 2f);
        transform.position = new Vector3(newX, newY, transform.position.z);

        isOffScreen = false;
    }
}
