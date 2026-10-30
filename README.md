# GameDev26-27

Course material for the **3D Game Development** tutorials (2026/27).
Each session has its own folder. Grab what you need, read the comments, and build.

> **Unity version:** 6.x (tested on 6.3 LTS).
> **Input:** tutorial 2 scripts use the **legacy Input Manager**. If input does nothing,
> set **Edit → Project Settings → Player → Active Input Handling** to **Both**
> (or *Input Manager (Old)*) and restart the Editor.

## Structure

| Folder | What's in it |
|---|---|
| [`first-tutorial/`](first-tutorial/) | Editor, navigation, prefabs, Asset Store, materials & PBR: the no-code basics (notes/recap). |
| [`second-tutorial/`](second-tutorial/) | Your first scripts: lifecycle, input, transform movement, follow camera, prefabs, triggers. **9 commented starter scripts.** |
| `gj1/` … `gj5/` | Materials posted before each session. |

## How to use a script

1. Download the repo (green **Code → Download ZIP**) or `git clone` it.
2. In your Unity project's **Project** window, open `Assets` and drag the `.cs`
   files (or the `Scripts` folder) into it.
3. Select an object → **Add Component** → type the script name. Read the comment
   block at the top of each file for what to attach it to and what to set.

> The file name and the class name inside must match (`PlayerMovement.cs` ↔
> `class PlayerMovement`), or Unity won't let you attach it.

## Questions?

Use the **Discussions** tab of this repo (Q&A). Ask anything - the answer helps
everyone. Typo or improvement? Pull requests welcome.
