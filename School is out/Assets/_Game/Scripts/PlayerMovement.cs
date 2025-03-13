using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 12f; // Movement speed
    public float gravity = -9.81f; // Gravity to apply to the player
    private Vector3 velocity;

    public Transform cameraTransform; // Reference to the Camera

    void Update()
    {
        // Get input for WASD movement
        float moveX = Input.GetAxis("Horizontal"); // A/D or Left/Right Arrow
        float moveZ = Input.GetAxis("Vertical"); // W/S or Up/Down Arrow

        // Calculate movement direction relative to the camera's rotation
        Vector3 move = cameraTransform.right * moveX + cameraTransform.forward * moveZ;

        // Ignore vertical movement (we don’t want to move the player up or down)
        move.y = 0f;

        // Apply movement
        controller.Move(move * speed * Time.deltaTime);

        // Apply gravity (this will make the player fall off the ground if they're not grounded)
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
}
