using UnityEngine;

// ─────────────────────────────────────────────────────────────────────────────
// COLOR CHANGER: swap the object's material colour with a key press.
//
// WHAT IT DOES: cycles through a list of colours each time you press a key.
// ATTACH TO:    any object with a Renderer (a Cube / Sphere).
// INSPECTOR:    fill the "Colors" list; choose the "Change Key" (default: C).
//
// REMINDER: editing material.color at runtime makes a private copy of the material
// for THIS object, so other objects sharing the material are not affected. This is
// the "basic colour" side of the materials you set up in Tutorial 1 (the PBR side -
// metallic/smoothness/texture maps - lives in the material asset itself).
//
// CONCEPTS (Tutorial 1 & 2): GetComponent<Renderer>() · material.color ·
// legacy Input.GetKeyDown · a simple array/index.
// ─────────────────────────────────────────────────────────────────────────────
public class ColorChanger : MonoBehaviour
{
    [SerializeField] private Color[] colors =
        { Color.white, Color.red, Color.green, Color.cyan, Color.yellow };
    [SerializeField] private KeyCode changeKey = KeyCode.C;

    private Renderer rend;
    private int index;

    private void Awake() => rend = GetComponent<Renderer>();

    private void Update()
    {
        // GetKeyDown is true only on the single frame the key goes down - perfect
        // for one-shot actions. (GetKey would be true every frame it's held.)
        if (Input.GetKeyDown(changeKey) && colors.Length > 0)
        {
            index = (index + 1) % colors.Length; // wrap back to 0 at the end
            rend.material.color = colors[index];
        }
    }
}
