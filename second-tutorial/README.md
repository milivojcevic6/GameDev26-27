# Second Tutorial: Your first scripts

Small, heavily-commented C# scripts that recap everything from the scripting
tutorial. Read them, drop them on objects, change the numbers in the Inspector, and
see what happens. Each script does **one** thing; the comment block at the top says
what to attach it to and what to set. The scripts live in [`Scripts/`](Scripts/).

## What these scripts cover

- MonoBehaviour **lifecycle**: `Awake`, `Start`, `Update`, `LateUpdate`
- **`[SerializeField]`** and tweaking values in the **Inspector**
- **`GetComponent`**, the **Renderer**, and **`material.color`**
- **`Debug.Log`** for seeing what your code does
- **Legacy input**: `GetAxisRaw`, `GetKeyDown`
- **Moving with the Transform**: `Translate`, `Rotate`, position over time
- **`Time.deltaTime`** / `Time.time` and `.normalized`
- **Prefabs**: `Instantiate` (spawn) and `Destroy` (remove)
- **Triggers**: `OnTriggerEnter` for pickups

## The scripts

| Script | What it does | Put it on | Key Inspector fields |
|---|---|---|---|
| **LifecycleDemo** | Shows the order `Awake → Start` run (and that `Awake` runs even when disabled). | Any object with a Renderer | none |
| **PlayerMovement** | WASD / arrows move the object via its Transform. | The Player | `Move Speed` |
| **CameraFollow** | Camera trails a target at a fixed offset (optionally smoothed). | Main Camera | `Target`, `Offset`, `Smooth` |
| **Rotator** | Spins the object forever. | Any object | `Degrees Per Second`, `Axis` |
| **Hover** | Bobs the object up and down (great on a coin). | Any object | `Amplitude`, `Frequency` |
| **ColorChanger** | Cycles the material colour on a key press. | Object with a Renderer | `Colors`, `Change Key` |
| **Spawner** | Spawns (Instantiates) a prefab on a key press. | An empty "spawn point" | `Prefab To Spawn`, `Spawn Key` |
| **SelfDestruct** | Destroys the object after N seconds. | Short-lived objects | `Lifetime` |
| **CollectibleTrigger** | Player walks into it → recolours player, optional VFX, destroys itself. | A collectible (trigger collider) | `New Player Color`, `Pickup VFX Prefab` |

## Wire up a tiny scene in ~10 minutes

A playground that uses most of the scripts, no physics required:

1. **Ground**: create a Plane (`GameObject → 3D Object → Plane`).
2. **Player**: a Cube with **PlayerMovement**. Set its **Tag** to `Player`.
3. **Camera**: select the Main Camera, add **CameraFollow**, drag the Player into
   **Target**.
4. **Collectible**: a small Sphere with **Is Trigger** ticked on its collider, plus
   **Hover**, **Rotator**, and **CollectibleTrigger**.
5. Press **Play**: drive the cube into the sphere → it vanishes and the cube changes
   colour.

That's lifecycle, input, transform movement, a follow camera, materials, prefabs,
Instantiate/Destroy and triggers, the whole tutorial in one scene.
