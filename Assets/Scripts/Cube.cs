using UnityEngine;

public class Cube : MonoBehaviour
{
    // Declaring amd initializing the variables and constants.
    public MeshRenderer Renderer;
    private const float Speed = 20.0f;
    
    
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
        // Moves the cube forward based on its position.
        transform.Translate(Vector3.forward * (Time.deltaTime * Speed));

        // Change the scale of the cube.
        transform.localScale = new Vector3(20.5f, 20.5f, 20.5f);
        
        // Rotates the cube around the different angles.
        transform.Rotate(10.0f * Time.deltaTime * 2, 15.0f * Time.deltaTime, -20.0f * Time.deltaTime);
    }
}
