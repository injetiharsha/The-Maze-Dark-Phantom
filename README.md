# The Maze: Dark Phantom

**The Maze: Dark Phantom** is a unique 3D audio-driven maze exploration game developed in Unity. Players navigate a dark and eerie maze using only spatial audio cues, guided by a faint head-mounted spotlight and realistic sound occlusion. Vision is minimal—sound is your only guide.

---

## 🎮 Concept

In a world where hearing becomes your only way to survive, this game challenges players to rely solely on directional sound to find their way through a mysterious, fog-filled maze. As you get closer to the beacon, the sound intensifies—helping you find the exit.

---

## 🔊 Audio Occlusion (Core Mechanic)

Audio Occlusion is a key gameplay mechanic in **The Maze: Dark Phantom**. It simulates how sound behaves in a 3D space by accounting for obstacles like walls and objects between the sound source and the listener (the player). 

In this game, the beacon sound, which helps the player navigate, becomes **muffled, blocked, or redirected** depending on the maze’s layout. This means players cannot simply follow volume alone; they must consider how sound is affected by walls and corners. The system uses Unity’s built-in spatial audio settings along with **occlusion simulation** to:

- Muffle sounds behind walls
- Reduce volume if obstacles block a direct path
- Provide realistic directional sound cues

This mechanic makes navigation more immersive and challenging, encouraging players to **listen carefully and move strategically**.

---

## 🚀 Features

- **Spatial Audio Navigation** – Navigate using footsteps, ambient sounds, whispers, and a finish beacon.
- **Immersive Visuals** – Nebula skybox, realistic terrain with grass and bushes, and limited visibility via fog.
- **Minimal Lighting** – Head-mounted spotlight provides a narrow vision cone.
- **Timer System** – Tracks the player’s time to reach the finish.
- **Player Name Input** – Enter your name before starting; name and time are recorded.
- **Finish Detection** – Finish point with trigger detection and scene transition.
- **Main Menu UI** – Simple UI with Play and Exit buttons and name input.
- **Built with Unity HDRP** – High-quality rendering and lighting system.

---

## 🕹️ Controls

| Action   | Key        |
|----------|------------|
| Move     | W / A / S / D |
| Run      | Shift      |
| Jump     | Space      |
| Crouch   | Left Ctrl  |

Each movement action includes corresponding sound effects.

---

## 🏁 Game Flow

1. Launch the game and enter your name in the main menu.
2. Begin the maze with only a spotlight and directional audio.
3. Follow the sound to find your way through.
4. Reach the beacon at the end to finish and record your time.

## Scene Flow
0 MainMenu -->
1 Game -->
2 Finish

---

## 📋 Requirements

- Unity 2021.3 or newer
- HDRP (High Definition Render Pipeline)
- Basic PC hardware (no VR required)

## 📦 Assets & Credits

Some of the environment textures, models, and sound effects used in this project were sourced from the Unity Asset Store under free or permitted educational licenses. All credited assets are used solely for learning and non-commercial purposes.


---
## 💡 Development
* Developed by Injeti Udaya Harsha
* Designed in Unity 6 | Audio-Driven Gameplay Concept




