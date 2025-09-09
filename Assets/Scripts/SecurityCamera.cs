using UnityEngine;

[RequireComponent(typeof(Camera))]
public class SecurityCamera : MonoBehaviour {
    private Camera camera;
    private RenderTexture renderTexture;

    [Header("Resolution")]
    [SerializeField] private int width = 128;
    public int Width => width;

    [SerializeField] private int height = 128;
    public int Height => height;
    public RenderTexture RenderTexture => renderTexture;
    
    private void Awake() {
        camera = GetComponent<Camera>();
        renderTexture = new RenderTexture(width, height, 24, RenderTextureFormat.ARGB32);
        camera.targetTexture = renderTexture;
    }
}
