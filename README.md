# F1 AR Viewer

An augmented reality app built with **Unity** and **Vuforia**, designed to recognize F1 team logos and display their respective 3D car models in real-time.
Users can interact with the 3D models through an on-screen joystick and access detailed information about each team.

## Features

**Home Menu**

Launch the image detection mode from the home menu or close the app.

![home menu](https://github.com/user-attachments/assets/0549a325-f10a-4ed3-b9a0-e1862789429f)


**Image Detection with Vuforia**  

Scan F1 team logos using your device’s camera to instantly display a 3D model of the corresponding team's Formula 1 car.
The F1 team logos for image dectection are available in "images" folder on this repository.

![no image detected](https://github.com/user-attachments/assets/ac98c16b-da31-4479-81a7-1210bf217f6f)


**Model Interaction**  

When a logo is detected, a virtual joystick (powered by the **Joystick Pack**) appears, allowing users to rotate and inspect the 3D car models.
Tap the "Information" button to reveal a panel containing detailed facts and background information about the selected F1 team.

![image detected](https://github.com/user-attachments/assets/4c24aa2d-2e47-4f64-9a28-119d3827374b)


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
