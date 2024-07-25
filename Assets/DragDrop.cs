using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private Vector3 offset;
    private bool isDragging = false;

    private void OnMouseDown()
    {
        // Calculate the offset between the mouse position and the object's position
        offset = gameObject.transform.position - GetMouseWorldPos();
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            // Update the object's position to follow the mouse position
            gameObject.transform.position = GetMouseWorldPos() + offset;
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }

    private Vector3 GetMouseWorldPos()
    {
        // Get the mouse position in screen coordinates and convert it to world coordinates
        Vector3 mousePos = Input.mousePosition;
        mousePos.z = Camera.main.nearClipPlane; // Set the z-coordinate to the camera's near clip plane
        return Camera.main.ScreenToWorldPoint(mousePos);
    }
} 