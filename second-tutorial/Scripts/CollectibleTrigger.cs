using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// COLLECTIBLE TRIGGER: a pickup that reacts when the player touches it.
//
// WHAT IT DOES: when the Player enters this object's trigger, it recolours the
//               player, optionally spawns a particle effect, and destroys itself.
// ATTACH TO:    the collectible object (a coin, gem, etc.).
// SETUP (important):
//   • This object needs a Collider with "Is Trigger" TICKED.
//   • The Player must be tagged "Player" (Inspector → Tag dropdown → Player).
//   • The Player needs a Collider, and at least one of the two needs a Rigidbody
//     for the trigger to fire.
// INSPECTOR:    pick "New Player Color"; optionally drag a particle prefab into
//               "Pickup VFX Prefab".
//
// TRIGGER vs COLLISION: a trigger lets objects pass through but still notifies you
// (OnTriggerEnter). A normal collider blocks movement (OnCollisionEnter - see
// CollisionResponse.cs).
//
// CONCEPTS (Tutorial 2): triggers · CompareTag · GetComponent · Instantiate · Destroy.
// ─────────────────────────────────────────────────────────────────────────────
public class CollectibleTrigger : MonoBehaviour
{
    [Header("Effects")]
    [SerializeField] private Color newPlayerColor = Color.green;
    [SerializeField] private GameObject pickupVFXPrefab; // optional

    private void OnTriggerEnter(Collider other)
    {
        // Only react to the player. CompareTag is the cheap, typo-safe way to check.
        if (!other.CompareTag("Player")) return;

        // 1. CHANGE THE PLAYER'S COLOUR
        Renderer playerRenderer = other.GetComponent<Renderer>();
        if (playerRenderer != null)
            playerRenderer.material.color = newPlayerColor;

        // 2. SPAWN A PARTICLE EFFECT (only if one was assigned)
        if (pickupVFXPrefab != null)
            Instantiate(pickupVFXPrefab, transform.position, Quaternion.identity);

        // 3. REMOVE THE COLLECTIBLE FROM THE SCENE
        Destroy(gameObject);
    }
}
