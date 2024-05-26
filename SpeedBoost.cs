using UnityEngine;
using StarterAssets;

public class SpeedBoost : Collectible
{
    public float speedIncreaseAmount = 2f;

    public override void Collected()
    {
        // Increase player's movement speed
        FirstPersonController playerController = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.MoveSpeed += speedIncreaseAmount;
            Debug.Log("SpeedBoost collected! Player speed increased by " + speedIncreaseAmount + ". New speed: " + playerController.MoveSpeed);
        }
        Destroy(gameObject); // Destroy the collectible after collection
    }
}
