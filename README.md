# Augmented Reality Unity

![Project Status](https://img.shields.io/badge/status-completed-brightgreen)

This project is created for the **Intelligent System** course. It demonstrates the implementation of **Augmented Reality (AR)** features using Unity across four different scenes. The project supports various devices, especially mobile devices that are ARCore-compatible.

> ⚠️ **Important Notice**: Upon opening this project for the first time, it may take a long time to load due to the need to resolve and download external libraries and dependencies. Before being pushed, the project size reached approximately **14 GB**. This project uses **Git LFS** (Large File Storage) for managing large assets such as `.fbx` and `.png` files.

## **Technologies Used**
- **Unity Engine**: For building AR experiences.
- **Vuforia Engine**: For image and object target tracking.
- **AR Foundation & ARCore**: For mobile-based AR functionality.
- **C#**: For scripting interactions.
- **Git LFS**: For storing large binary assets efficiently.

## **Demo**

### **AR Basic**
A basic AR scene that displays a 3D object in the real world using Unity's AR features.
- 📺 Tutorial: [YouTube](https://youtu.be/I7u8aOsxBVU?feature=shared)

<img width="683" alt="scene_basic" src="https://github.com/user-attachments/assets/3ba76ee4-1d68-4405-8fde-3bf80ec93db8" />

### **AR Marker**
An AR scene using **Vuforia Engine** to display a 3D object when a specific marker (image target) is detected.
- 🧊 3D Model Source: [Sketchfab - Wyvern](https://sketchfab.com/3d-models/wyvern-animated-1dc70bbf15c2456a85290c8613b6c1ff)
- 📺 Tutorial: [YouTube](https://youtu.be/yfLSJuohaFQ?feature=shared)

<img width="683" alt="scene_marker2" src="https://github.com/user-attachments/assets/024c4040-6fd6-440a-b7f3-62bc32c80056" />
<img width="684" alt="scene_marker1" src="https://github.com/user-attachments/assets/876e646b-7666-44e1-9baa-f971ad8b0f01" />
<img width="686" alt="scene_marker3" src="https://github.com/user-attachments/assets/854caf10-b62d-4c95-be00-701d2df3a32c" />

### **AR API**
This scene displays a text object retrieved dynamically from an API (weather data) when an image marker is detected.
- 🌐 API Source: [OpenWeatherMap](https://openweathermap.org/api)
- 📺 Tutorial: [YouTube](https://youtu.be/5PucjjRxQ9Q?feature=shared)

<img width="686" alt="scene_cuaca1" src="https://github.com/user-attachments/assets/06bbabbb-2634-4ffa-b39b-f5e4901fc761" />
<img width="683" alt="scene_cuaca2" src="https://github.com/user-attachments/assets/6fe8cd83-533c-4f33-a30f-7cb5db4713b5" />

### **AR Multitarget**
Implements multitarget AR using Vuforia, where a 3D object is displayed based on a 3D-form marker such as a box.
- 🧊 3D Model Source: [Sketchfab - Vernier Caliper](https://sketchfab.com/3d-models/verniercaliper-205ebdec7304449bb8d2effbfe272ec8)

<img width="176" alt="scene_multitarget3" src="https://github.com/user-attachments/assets/865e5f07-f40f-4956-8aaf-52cd138b1fef" />
<img width="683" alt="scene_multitarget2" src="https://github.com/user-attachments/assets/b9f08d86-1110-43df-8e40-575e5791e879" />
<img width="685" alt="scene_multitarget1" src="https://github.com/user-attachments/assets/2f6f0c76-c5a2-4e5e-8f1b-99d7cd1d4e81" />

## **Setup**
1. Clone the repository to your local machine.
2. Open the project folder in **Unity Hub** and select the correct Unity version.
3. Ensure you have installed AR Foundation, ARCore XR Plugin, and Vuforia Engine.
4. Allow Unity to import all packages and resolve dependencies. This may take significant time on the first open.
5. Load the scene you want to test (`ARBasic`, `ARMarker`, `ARAPI`, or `ARMultitarget`) from the `Scenes` folder.

## **Usage**
1. Explore each of the 4 AR scenes to understand various AR concepts.
2. Deploy to ARCore-compatible devices for real-world testing.
3. Modify the assets, markers, and logic to expand or personalize the experience.

## **Project Status**
This project is **completed** and was developed for educational purposes as part of the **Intelligent System (Sistem Cerdas)** course.

## **Contributions**
Contributions are welcome! Feel free to submit issues or create pull requests to improve the project.

## **Disclaimer**
Some assets (images, 3D models) are used for educational purposes only. All credits go to their respective owners. Not for commercial use.
