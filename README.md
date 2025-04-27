# F1 AR Viewer

An augmented reality app built with **Unity** and **Vuforia**, designed to recognize F1 team logos and display their respective 3D car models in real-time.
Users can interact with the 3D models through an on-screen joystick and access detailed information about each team.
The F1 team logos are available in "images" folder on this repository.

## Features

- **Image Detection with Vuforia**  
  Scan F1 team logos using your device’s camera to instantly display a 3D model of the corresponding team's Formula 1 car.

- **Model Interaction**  
  When a logo is detected, a virtual joystick (powered by the **Joystick Pack**) appears, allowing users to rotate and inspect the 3D car models.

- **Team Information Panel**  
  Tap the "Information" button to reveal a panel containing detailed facts and background information about the selected F1 team.

## 3D Models

- All 3D car models used in this project are sourced from [**Redgrund's Sketchfab profile**](https://sketchfab.com/redgrund).
- Models are imported into Unity using the **gltfast** plugin for optimized glTF loading.

## Requirements

- Unity 2021.3 LTS or higher (recommended)
- Vuforia Engine
- Joystick Pack (for Unity UI joystick control)
- gltfast (for loading glTF/glb models)

## Credits

- 3D Models by [Redgrund](https://sketchfab.com/redgrund)

## License

This project is intended for educational and non-commercial use.  
