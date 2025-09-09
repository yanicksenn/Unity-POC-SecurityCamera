# POC Security Camera

![recording](https://raw.githubusercontent.com/yanicksenn/Unity-POC-SecurityCamera/cbac048bfbe05ba6439011641821628f2061aa1a/Img/recording.gif)   

A proof of concept project that shows how an in-game security camera system could be built.

## Basic Idea

1. Assign `RenderTexture` to a `Camera` (SecurityCamera.cs)
1. Pipe the `RenderTexture` of the `Camera` into the MainTex of a Shader (SecurityScreen.cs)

## Extensions

1. Render the `RenderTexture` with a custom shader that imitates a CRT screen (shader_monitor)
1. Add REC text to the Camera which will be drawn onto the `RenderTexture`
