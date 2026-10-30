using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// CAMERA FOLLOW: make the Main Camera trail the player.
//
// WHAT IT DOES: keeps the camera at a fixed offset behind/above a target.
// ATTACH TO:    the Main Camera.
// INSPECTOR:    drag the Player into "Target"; set "Offset" (how far back/up).
//               Tick "Smooth" for a soft, lagging follow instead of a hard snap.
//
// WHY LateUpdate()? It runs AFTER every Update() has finished. The player moves in
// Update, THEN the camera reads its final position - no jitter from the camera
// reacting to a stale, one-frame-old position.
//
// CONCEPTS (Tutorial 2): static camera → follow camera · LateUpdate · null-checks ·
// Vector3.Lerp for smoothing.
// ─────────────────────────────────────────────────────────────────────────────
public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;                       // the Player
    [SerializeField] private Vector3 offset = new Vector3(0f, 6f, -9f);

    [SerializeField] private bool smooth = true;
    [SerializeField] private float smoothSpeed = 8f; // higher = snappier

    private void LateUpdate()
    {
        // If the target was destroyed (or never assigned) do nothing instead of
        // throwing a NullReferenceException.
        if (target == null) return;

        Vector3 desired = target.position + offset;

        if (smooth)
            // Ease toward the target position a fraction of the way each frame.
            transform.position = Vector3.Lerp(transform.position, desired,
                                              smoothSpeed * Time.deltaTime);
        else
            // Hard snap: the camera is always exactly at target + offset.
            transform.position = desired;
    }
}
