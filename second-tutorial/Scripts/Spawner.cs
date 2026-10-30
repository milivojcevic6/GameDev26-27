using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// SPAWNER: create copies of a PREFAB at runtime with a key press.
//
// WHAT IT DOES: every time you press the key, it Instantiates (spawns) a copy of
//               a prefab at this object's position.
// ATTACH TO:    an empty GameObject used as a "spawn point".
// SETUP:        make a prefab first (drag an object from the Hierarchy into the
//               Project window - the Tutorial 1 skill), then drag that prefab asset
//               into the "Prefab To Spawn" slot here.
// INSPECTOR:    "Prefab To Spawn" and "Spawn Key" (default: Space).
//
// This is the script-side partner to making prefabs by hand: a prefab is a reusable
// template, and Instantiate() stamps out as many live copies as you want.
//
// CONCEPTS (Tutorial 1 & 2): prefabs · Instantiate() · legacy Input.GetKeyDown ·
// Quaternion.identity (= "no rotation").
// ─────────────────────────────────────────────────────────────────────────────
public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject prefabToSpawn;
    [SerializeField] private KeyCode spawnKey = KeyCode.Space;

    private void Update()
    {
        if (Input.GetKeyDown(spawnKey))
        {
            if (prefabToSpawn == null)
            {
                Debug.LogWarning("Spawner: no prefab assigned in the Inspector.");
                return;
            }

            // Create a copy at this spawn point, with no rotation.
            Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
        }
    }
}
