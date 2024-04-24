using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Zenject;

public class MovementController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _player;
    [SerializeField] private float _forceMultiplier = 1;
    private IHorizontalInput _horizontalInput;

    [Inject]
    private void Construct(IHorizontalInput horizontalInput)
    {
        _horizontalInput = horizontalInput;
        _horizontalInput.OnHorizontalInput += Move;
    }

    private void Move(float value)
    {
        _player.AddForce(Vector2.right * value * Time.deltaTime * _forceMultiplier);
    }
}
