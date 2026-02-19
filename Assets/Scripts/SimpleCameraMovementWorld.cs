using UnityEngine;
using UnityEngine.InputSystem;

public class SimpleCameraMovementWorld : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // Usar o novo Input System
        float moveX = 0f;
        float moveZ = 0f;

        // Teclado
        if (Keyboard.current != null)
        {
            if (Keyboard.current.aKey.isPressed || Keyboard.current.leftArrowKey.isPressed)
                moveX = -1f;
            if (Keyboard.current.dKey.isPressed || Keyboard.current.rightArrowKey.isPressed)
                moveX = 1f;
            if (Keyboard.current.wKey.isPressed || Keyboard.current.upArrowKey.isPressed)
                moveZ = 1f;
            if (Keyboard.current.sKey.isPressed || Keyboard.current.downArrowKey.isPressed)
                moveZ = -1f;
        }

        Vector3 move = new Vector3(moveX, 0, moveZ);
        transform.position += move * moveSpeed * Time.deltaTime;
    }
}