using UnityEngine;

namespace ElbowGames
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Camera _camera;
        [SerializeField] private Transform _backgroundTransform;
        [SerializeField] private Transform _player;
        [SerializeField] private float _maxYOffset = 0;
        [SerializeField] private float _cameraDistance = -1;
        [SerializeField] private float _backgroundDistance = 1;
        private Transform _cameraTransform;

        private void Awake()
        {
            _cameraTransform = _camera.transform;
        }

        private void LateUpdate()
        {
            float upperY = _player.position.y + _maxYOffset;
            float lowerY = _player.position.y - _maxYOffset;
            if (_cameraTransform.position.y > upperY)
            {
                _cameraTransform.position = new Vector3(0, upperY, _cameraDistance);
                _backgroundTransform.position = new Vector3(0, upperY, _backgroundDistance);
            }

            else if (_cameraTransform.position.y < lowerY)
            {
                _cameraTransform.position = new Vector3(0, lowerY, _cameraDistance);
                _backgroundTransform.position = new Vector3(0, lowerY, _backgroundDistance);
            }

        }
    }
}