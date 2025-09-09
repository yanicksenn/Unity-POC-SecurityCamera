# POC Security Camera

A proof of concept project that shows how in in-game security camera system could be built.

## Basic Idea

1. Assign `RenderTexture` to a `Camera` (SecurityCamera.cs)
1. Pipe the `RenderTexture` of the `Camera` into the MainTex of a Shader (SecurityScreen.cs)

## Extensions

1. Render the `RenderTexture` with a custom shader that imitates a CRT screen (shader_monitor)
1. Add REC text to the Camera which will be drawn onto the `RenderTexture`
