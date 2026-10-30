using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// ROTATOR: the simplest possible "it works!" script.
//
// WHAT IT DOES: spins the object it is attached to, forever.
// ATTACH TO:    any object with a visible mesh (Cube, Sphere, an imported prop).
// INSPECTOR:    set "Degrees Per Second" (how fast) and "Axis" (which way to spin).
//
// CONCEPTS (Tutorial 2): Update() runs every frame · Time.deltaTime makes speed
// frame-rate independent · [SerializeField] exposes a private field in the Inspector.
// ─────────────────────────────────────────────────────────────────────────────
public class Rotator : MonoBehaviour
{
    [SerializeField] private float degreesPerSecond = 90f;
    [SerializeField] private Vector3 axis = Vector3.up; // (0,1,0) = spin around Y

    private void Update()
    {
        // Multiplying by Time.deltaTime turns "per frame" into "per second":
        // at 60 FPS and 144 FPS the object completes the same rotation each second.
        transform.Rotate(axis * degreesPerSecond * Time.deltaTime);
    }
}
