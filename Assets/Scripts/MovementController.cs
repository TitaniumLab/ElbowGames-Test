using ElbowGames.Input;
using UnityEngine;
using Zenject;

namespace ElbowGames
{
    public class MovementController : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D _player;
        [SerializeField] private float _horizForceMulti = 1;
        private IHorizontalInput _horizontalInput;

        [Inject]
        private void Construct(IHorizontalInput horizontalInput)
        {
            _horizontalInput = horizontalInput;
            _horizontalInput.OnHorizontalInput += HorizontalMove;
        }

        private void HorizontalMove(float value)
        {
            _player.AddForce(Vector2.right * value * Time.deltaTime * _horizForceMulti);
        }
    }
}
