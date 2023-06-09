# DPM_Unity_VR

Dual paraboloid mapping (DPM) is an approach for environment mapping that utilizes the reflection of two paraboloid surfaces. Compared to the popular cube mapping approach (CM), DPM offers a major advantage in terms of faster map generation speed. In this project, we implemented the Seamless Mipmap Filtering algorithm for DPM and compared it to CM in a VR platform (Oculus Quest 2) using Unity.


## About The Project

![demo](https://github.com/HeyMyFriends/DPM_Untiy_VR/blob/main/Demo.png)
This project showcases the use of DPM and CM to create omnidirectional soft shadows on the Oculus Quest 2.
It can be divided into three main parts:
1. Shadow map generation.
2. Shadow map sampling.
3. VR interaction implementation.

For more information on the implementation details, please refer to the [link](https://spiny-globe-90c.notion.site/DPM-Unity-dc2329df3d8943ac9b64de44bd2b3640). 

Additionally, you can access a demo of the webgl version of the project [here](https://heymyfriends.github.io/DPM/).

### Content
This project includes several C# and Unity shader scripts. Their roles are shown as follows.

1. Scripts:


* [Assets/Scripts/LightSource.cs](https://github.com/HeyMyFriends/DPM_Untiy_VR/blob/main/Assets/Scripts/LightSource.cs)<br>
   It is used to set cameras for generating the dual paraboloid shadow map.


* [Assets/Scripts/CM/LightSource_CM.cs](https://github.com/HeyMyFriends/DPM_Untiy_VR/blob/main/Assets/Scripts/CM/LightSource_CM.cs)<br>
   It is used to set cameras for generating the cubemap shadow map.


* [Assets/Scripts/Vr](https://github.com/HeyMyFriends/DPM_Untiy_VR/tree/main/Assets/Scripts/Vr)<br>
   It is used to implement VR interaction.


* [Assets/Scripts/Basic](https://github.com/HeyMyFriends/DPM_Untiy_VR/tree/main/Assets/Scripts/Basic)<br>
   It is used to define the fundamental logic of certain objects, including the movement of robots.

2. Shaders:


* [Assets/Shaders/CM](https://github.com/HeyMyFriends/DPM_Untiy_VR/tree/main/Assets/Shaders/CM)<br>
   It is used for generating the omnidirectional soft shadow with CM.


* [Assets/Shaders/DPM](https://github.com/HeyMyFriends/DPM_Untiy_VR/tree/main/Assets/Shaders/DPM)<br>
   It is used for generating the omnidirectional soft shadow with DPM.


### Prerequisites
This project is designed to run on the VR platform(Oculus Quest 2), and can also be viewed directly in the editor. If you wish to experience it in VR, please ensure that your environment is properly configured beforehand.<br>
[Oculus Quest2 development environment configuration](https://spiny-globe-90c.notion.site/Environment-Configuration-ad5256a8c78f4f50a89be201534c7169) 

### Installation
1. Clone or download the repository.
2. Open up the Unity project and run the [Assets/Scenes/MainScene](https://github.com/HeyMyFriends/DPM_Untiy_VR/blob/main/Assets/Scenes/MainScene.unity) in Assets.

### Operation
| Control        | Action                                          |
|----------------|-------------------------------------------------|
| Right Thumbstick | Rotate the camera                               |
| Left Thumbstick  | Move the character                              |
| Right Trigger    | Increase the size of the light source           |
| Left Trigger     | Decrease the size of the light source           |
| Right Grip       | Turn the UI interface on or off                 |
| A Button         | Increase the strength of the light source       |
| B Button         | Decrease the strength of the light source       |
| X Button         | Switch between DPM and CM                       |



