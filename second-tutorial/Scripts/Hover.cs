using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// HOVER: make an object gently bob up and down.
//
// WHAT IT DOES: floats the object above its starting height in a smooth wave.
//               Looks great on a collectible so it reads as "pick me up".
// ATTACH TO:    any object (try it together with CollectibleTrigger on a coin).
// INSPECTOR:    "Amplitude" = how high it bobs; "Frequency" = how fast.
//
// CONCEPTS (Tutorial 2): remembering a start value in Start() · moving the
// Transform over time · using Time.time with Mathf.Sin for a smooth wave.
// ─────────────────────────────────────────────────────────────────────────────
public class Hover : MonoBehaviour
{
    [SerializeField] private float amplitude = 0.5f; // height of the bob (units)
    [SerializeField] private float frequency = 1f;   // bobs per second

    private Vector3 startPosition;

    private void Start()
    {
        // Save where we began so we always bob around THAT point.
        startPosition = transform.position;
    }

    private void Update()
    {
        // Mathf.Sin swings smoothly between -1 and 1 over time → a soft up/down wave.
        float offsetY = Mathf.Sin(Time.time * frequency * Mathf.PI * 2f) * amplitude;
        transform.position = startPosition + new Vector3(0f, offsetY, 0f);
    }
}
