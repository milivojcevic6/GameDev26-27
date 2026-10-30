using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// PLAYER MOVEMENT: move an object with the keyboard, using its Transform.
//
// WHAT IT DOES: WASD / arrow keys slide the object around the scene.
// ATTACH TO:    the Player object.
// INSPECTOR:    "Move Speed" (units per second).
//
// This moves the Transform directly (no physics), so it is the method you already
// know from the tutorials. Note that it will pass THROUGH other objects, because it
// doesn't use the physics system.
//
// CONCEPTS (Tutorial 2): legacy Input · Update() · Time.deltaTime · .normalized.
// ─────────────────────────────────────────────────────────────────────────────
public class PlayerMovement : MonoBehaviour
{
    // [SerializeField] keeps the field private to this script but still shows it in
    // the Inspector, so you can tweak it without touching code.
    [SerializeField] private float moveSpeed = 5f;

    // Update runs once per frame - the place for reading input and visual movement.
    private void Update()
    {
        // 1. READ INPUT (legacy Input Manager)
        // GetAxisRaw → exactly -1, 0, or 1 (snappy). GetAxis → smoothed (glidey).
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        // 2. BUILD A DIRECTION
        // .normalized stops diagonal movement from being faster than straight.
        Vector3 direction = new Vector3(x, 0f, z).normalized;

        // 3. MOVE
        // Time.deltaTime keeps speed the same on fast and slow machines.
        // Space.World moves along the scene's axes, not the object's own rotation.
        transform.Translate(direction * moveSpeed * Time.deltaTime, Space.World);
    }
}
