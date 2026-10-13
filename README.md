# Unity Gym App

A 3D gym simulation built in Unity for a Human-Computer Interaction semester project.
You walk around a gym, visit reception, and use the equipment to train.

## Features

- Third-person movement with a follow camera and camera rotation
- Reception desk with a menu: gym plans (upper / lower body), diet plans, a shop and your stats
- An advisor who gives advice based on your body weight
- Exercises: treadmill, weights, deadlift, pull-ups and sit-ups, each raising different stats
- Player stats for arms, core, legs, chest, back and weight
- Prompts that appear when you approach equipment

## Requirements

- Unity **2022.3.26f1** (any 2022.3 LTS version should work)

## Getting started

1. Clone the repo:
   ```
   git clone https://github.com/Thodorhspap/UnityGymApp.git
   ```
2. Open the folder in Unity Hub (**Add project from disk**).
3. Import the texture packs listed below.
4. Open `Assets/Scenes/SampleScene.unity` and press Play.

## Texture packs (not included)

These free third-party packs are left out of the repo because of their license and size (about 1.1 GB).
Download them from the Unity Asset Store and import them through **Window > Package Manager > My Assets**:

| Pack | Folder it imports into |
|---|---|
| Wooden Floor Pack | `Assets/Free/Wooden Floor Pack` |
| Concrete textures pack | `Assets/Concrete textures pack` |

Until you import them, floors and walls that use these textures appear pink (missing material).

## Scripts

| Script | What it does |
|---|---|
| `Capsule_Movement1.cs` | Player movement |
| `Capsule_Stats.cs` | Player stats |
| `Camera_Follow.cs`, `Camera_Rotation.cs`, `move head.cs` | Camera control |
| `Interaction_Collider.cs`, `Show_text_on_aproach.cs` | Proximity interactions and prompts |
| `Reception_Interaction1.cs` | Reception desk menu |
| `Advisor.cs` | Weight-based advice |
| `Treadmill.cs`, `Weights.cs`, `Deadlift.cs`, `Pull-Ups.cs`, `Sit-ups.cs` | Exercises |
| `Menu_Options.cs`, `UI_Manager.cs` | Menus and UI |
