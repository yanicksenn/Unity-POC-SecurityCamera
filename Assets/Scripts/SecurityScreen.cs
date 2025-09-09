using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class SecurityScreen : MonoBehaviour {
    private Renderer renderer;
    
    [Header("Connections")]
    [SerializeField]
    private SecurityCamera[] securityCameras;
    private int currentScreenIndex = 0;

    private void Awake() {
        renderer = GetComponent<Renderer>();
    }

    private void Start() {
        UpdateCurrentRenderTexture();
    }

    private void UpdateCurrentRenderTexture() {
        if (securityCameras.Length == 0) return;
        var index = (securityCameras.Length + currentScreenIndex % securityCameras.Length) % securityCameras.Length;
        var securityCamera = securityCameras[index];
        renderer.material.mainTexture = securityCamera.RenderTexture;
    }

    public void SelectNextSecurityCamera() {
        currentScreenIndex++;
        UpdateCurrentRenderTexture();
    }
    
    public void SelectPreviousSecurityCamera() {
        currentScreenIndex--;
        UpdateCurrentRenderTexture();
    }
}
