using UnityEngine;

namespace ElbowGames.Animations
{
    [RequireComponent(typeof(Player))]
    public class PlayerAnim : MonoBehaviour
    {
        private Player _player;
        [SerializeField] private Rigidbody2D _rigidbody;

        private void Awake()
        {
            _player = GetComponent<Player>();
            _player.OnDamageTaken += Fall;
        }

        private void Fall()
        {
            _rigidbody.isKinematic = false;
        }
    }
}