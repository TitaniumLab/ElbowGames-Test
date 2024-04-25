using DG.Tweening;
using UnityEngine;

namespace ElbowGames.Animations
{
    public class LoadIcon : MonoBehaviour
    {
        [SerializeField] private float _rotationTime;
        private RectTransform _rectTransform;


        private Tween _tween;
        private void Awake()
        {
            _rectTransform = GetComponent<RectTransform>();
        }

        private void OnEnable()
        {
            RotateImage();
        }
        private void OnDestroy()
        {
            _tween?.Kill();
        }

        private void RotateImage()
        {
            _tween = _rectTransform.DORotate(new Vector3(0, 0, -360), _rotationTime, RotateMode.LocalAxisAdd);
        }
    }
}
