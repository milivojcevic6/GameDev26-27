# First Tutorial: Getting around Unity (no code yet)

A recap of what we did in the first session. This one is about finding your way
around the Editor and dressing a scene; no scripting yet (that's the
[second tutorial](../second-tutorial/)).

## What we covered

**Unity Hub & projects**
- Installing/choosing a Unity version through **Unity Hub**, creating a project with
  the **3D (URP)** template.

**The Editor layout**
- The main windows and what each is for: **Scene** (build the world), **Game**
  (what the player sees), **Hierarchy** (objects in the scene), **Inspector**
  (the selected object's components), **Project** (your files/assets), **Console**
  (messages, warnings, errors).
- **Navigating the Scene view:** right-mouse look + WASD to fly, Alt+drag to orbit,
  scroll to zoom, press **F** to frame the selected object.

**Organising a project**
- Keeping `Assets` tidy with folders: `Scenes`, `Materials`, `Prefabs`, `Scripts`, …
- The **Asset Store** (via the web) and **Package Manager** for importing free assets.

**Prefabs**
- Turning an object into a reusable **prefab** by dragging it from the Hierarchy into
  the Project window.
- Editing the base prefab updates every copy in the scene automatically.
- Prefab Variants: Reusable variations of a base prefab that inherit its core properties but allow specific overrides (such as a different material or faster movement speed) without severing the link to the original.
- Creating Variants: Right-click an existing prefab in the Project window and select Create > Prefab Variant, or drag a modified prefab instance from the Hierarchy back into the Project window and choose Prefab Variant from the prompt.

**Render pipeline**
- We use **URP** (Universal Render Pipeline) for this course - lighter and more
  flexible than Built-in; **HDRP** is the high-end pipeline.
- If imported assets look **bright pink**, their materials are Built-in and need
  converting: **Edit → Rendering → Materials → Convert…** (Render Pipeline Converter).

**Materials**
- Creating a **Material**, setting a **basic colour** (Albedo/Base Map).
- **PBR** inputs on a URP **Lit** material: **Metallic** and **Smoothness**, and
  plugging in texture maps (base colour, normal, etc.).

## Where to go deeper

- Unity Editor interface → https://docs.unity3d.com/Manual/UsingTheEditor.html
- Prefabs → https://docs.unity3d.com/Manual/Prefabs.html
- Materials in URP → https://docs.unity3d.com/Manual/materials-introduction.html

➡️ **Next:** [`second-tutorial/`](../second-tutorial/) : your first scripts.
