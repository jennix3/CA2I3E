using UnityEngine;
using StarterAssets;

public class JumpBoost : Collectible
{
    public float jumpIncreaseAmount = 0.5f;

    public override void Collected()
    {
        // Increase player's jump height
        FirstPersonController playerController = GameObject.FindWithTag("Player").GetComponent<FirstPersonController>();
        if (playerController != null)
        {
            playerController.JumpHeight += jumpIncreaseAmount;
            Debug.Log("JumpBoost collected! Player jump height increased by " + jumpIncreaseAmount + ". New jump height: " + playerController.JumpHeight);
        }
        Destroy(gameObject); // Destroy the collectible after collection
    }
}
