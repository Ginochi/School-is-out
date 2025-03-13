using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f; // Movement speed
    public Transform cameraTransform; // Reference to the Camera

    void Update()
    {
        // Get input for movement
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float moveZ = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow

        // Convert input to a movement vector relative to the camera
        Vector3 move = cameraTransform.forward * moveZ + cameraTransform.right * moveX;
        move.y = 0; // Ensure movement stays horizontal
        move.Normalize(); // Prevent diagonal movement from being faster

        // Move the player
        controller.Move(move * speed * Time.deltaTime);
    }
}
