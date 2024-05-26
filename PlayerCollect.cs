using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Collectible collectible = other.GetComponent<Collectible>();
        if (collectible != null)
        {
            Debug.Log("Collectible detected: " + collectible.GetType().Name);
            collectible.Collected();
        }
    }
}
