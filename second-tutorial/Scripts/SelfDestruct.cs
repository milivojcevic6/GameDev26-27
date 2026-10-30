using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// SELF DESTRUCT: remove an object automatically after a few seconds.
//
// WHAT IT DOES: destroys the object it's on after a set delay.
// ATTACH TO:    anything short-lived - a spawned particle effect, a temporary prop,
//               a copy made by Spawner.cs that you don't want piling up forever.
// INSPECTOR:    "Lifetime" in seconds.
//
// Destroy() takes an optional second argument: a delay in seconds. One line does it.
//
// CONCEPTS (Tutorial 2): Start() for one-time setup · Destroy(gameObject, delay).
// ─────────────────────────────────────────────────────────────────────────────
public class SelfDestruct : MonoBehaviour
{
    [SerializeField] private float lifetime = 3f;

    private void Start()
    {
        // Schedule this object to be removed after `lifetime` seconds.
        Destroy(gameObject, lifetime);
    }
}
