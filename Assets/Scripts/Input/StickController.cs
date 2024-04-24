using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.OnScreen;
using UnityEngine.UI;

public class StickController : MonoBehaviour
{
    private Image _backgroundImage;
    private Image _stickImage;
    private OnScreenStick _onScreenStick;
    private void Awake()
    {
        _backgroundImage = GetComponent<Image>();
        _stickImage = GetComponentInChildren<Image>();
        _onScreenStick = GetComponentInChildren<OnScreenStick>();

        _backgroundImage.enabled = false;
        _stickImage.enabled = false;
    }

    private void Update()
    {
        if (InputSystem.get)
        {
            
        }
    }
}
