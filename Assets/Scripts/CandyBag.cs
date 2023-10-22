using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CandyBag : MonoBehaviour
{
    //Detects collisions between the candy and character
    private void OnTriggerEnter(Collider other)
    {
        // Checks if the collision is with the character
        CandyInventory candyInventory = other.GetComponent<CandyInventory>();

        // If collides with character, updates number of candies in the inventory and deactivates the diamond 
        if (candyInventory != null)
        {
            candyInventory.CandyBagCollected();
            Destroy(this.gameObject);
        }
    }
}
