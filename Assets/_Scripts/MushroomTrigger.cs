using UnityEngine;

public class MushroomTrigger : MonoBehaviour
{
    
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("COllided with something" + other.name);
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has triggered the mushroom!");
            // Add additional logic here, e.g., increase score, play sound, etc.
            Destroy(gameObject);
        }
    }


}
