using UnityEngine;

public class Cube : MonoBehaviour
{
    // Declaring amd initializing the variables and constants.
    public MeshRenderer Renderer;
    private const float SpeedTranslation = 20.0f;
    private const float SpeedRotation = 5.0f;
    private Material _material;
    private Color _startColor; 
    private readonly Color _endColor = new Color(0.0f, 0.0f, 0.5f, 0.4f);
    private const float Duration = 5.0f;
    private float _elapsedTime;
    private float _opacity;
    
    
    private void Start()
    {
        // Sets the opacity randomly at the start of the scene.
        _opacity = Random.Range(0.2f, 0.9f);

        // _startcolor uses the randomly generated opacity
        _startColor = new Color(0.5f, 1.0f, 0.3f, _opacity);

        
        
        // Sets the position and scale of the cube.
        transform.position = new Vector3(3, 4, 1);
        transform.localScale = Vector3.one * 1.3f;
        
        // Saving the material of the MeshRenderer (3D object renderer) so it can later be manipulated.
        _material = Renderer.material;
        
        // Sets the Color for the Cube based on RGB values.
        _material.color = _startColor;
    }
    
    private void Update()
    {
        // Moves the cube forward based on its position.
        transform.Translate(Vector3.forward * (Time.deltaTime * SpeedTranslation));

        // Change the scale of the cube.
        transform.localScale = new Vector3(20.5f, 20.5f, 20.5f);
        
        // Rotates the cube around the different angles.
        transform.Rotate(10.0f * Time.deltaTime * SpeedRotation, 15.0f * Time.deltaTime, -20.0f * Time.deltaTime);
        
        // Advances time.
        _elapsedTime += Time.deltaTime;

        // Calculates the Time that as passed.
        var t = _elapsedTime / Duration;

        // Transitions the colors from startColor to endColor while keeping the opacity.
        Color currentColor = Color.Lerp(_startColor, _endColor, t);
        currentColor.a = _opacity; 
        _material.color = currentColor;

    }
}
