using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator doorAnimator; // Reference to the Animator component for the door

    // This function is called when the door collider is touched
    private void OnMouseDown()
    {
        // Toggle the state of the door animation
        doorAnimator.SetBool("isOpen", !doorAnimator.GetBool("isOpen"));
    }
}