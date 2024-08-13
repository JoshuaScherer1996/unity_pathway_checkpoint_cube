using UnityEngine;

public class Cube : MonoBehaviour
{
    // Declaring the variable.
    public MeshRenderer Renderer;
    
    private void Start()
    {
        // Sets the psoition and scale of the cube.
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        // Saving the material of the MeshRenderer (3D object renderer) so it can later be manipulated.
        Material material = Renderer.material;
        
        // Sets the Color for the Cube based on RGB values.
        material.color = new Color(0.5f, 1.0f, 0.3f, 0.4f);
    }
    
    private void Update()
    {
        // Rotates the cube around the xAngle.
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }
}
