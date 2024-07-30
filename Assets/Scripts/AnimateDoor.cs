using UnityEngine;
using UnityEngine.UI;

//using TMPro;

public class AnimateDoor : MonoBehaviour
{
    public Animator doorAnimator;
    public Button doorToggleButton;
    private bool isDoorOpen = false;
    //public TMP_Text buttonText;

    private void Start()
    {
        doorToggleButton.onClick.AddListener(ToggleDoor);
        UpdateDoorState();
    }

    public void ToggleDoor()
    {
        isDoorOpen = !isDoorOpen;
        UpdateDoorState();
    }

    private void UpdateDoorState()
    {
        doorAnimator.SetBool("isOpen", isDoorOpen); doorToggleButton.GetComponentInChildren<Text>().text = isDoorOpen ? "Close Door" : "Open Door";
    }
}