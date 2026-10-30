using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// LIFECYCLE DEMO: see WHEN Unity's event methods run, and in what order.
//
// WHAT IT DOES: logs each lifecycle method to the Console and recolours the object
//               so you can SEE the order (red in Awake → blue in Start).
// ATTACH TO:    any object with a Renderer (a Cube/Sphere).
// TRY THIS:     press Play with the script enabled, then DISABLE the component's
//               checkbox and press Play again. Awake still runs; Start does not.
//
// ORDER PER OBJECT:  Awake → OnEnable → Start → (Update every frame…)
//
// CONCEPTS (Tutorial 2): MonoBehaviour lifecycle · GetComponent · Debug.Log ·
// enabled vs disabled components.
// ─────────────────────────────────────────────────────────────────────────────
public class LifecycleDemo : MonoBehaviour
{
    private Renderer objRenderer;

    // Awake: runs once when the object loads - BEFORE Start, and even if this
    // component is disabled. Good place to cache references with GetComponent.
    private void Awake()
    {
        objRenderer = GetComponent<Renderer>();
        if (objRenderer != null) objRenderer.material.color = Color.red;

        Debug.Log("AWAKE: I run first, even if the script is disabled.");
    }

    // Start: runs once, just before the first Update - but ONLY if the component
    // is enabled. Good place for setup that depends on other objects being ready.
    private void Start()
    {
        if (objRenderer != null) objRenderer.material.color = Color.blue;

        Debug.Log("START: I run second, only when the script is enabled.");
    }
}
