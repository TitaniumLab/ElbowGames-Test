using DG.Tweening;
using UnityEngine;

namespace ElbowGames.Animations
{
    public class SawAnimator : MonoBehaviour
    {
        private Tween _tween;
        [SerializeField] private float _rotationTime = 1;

        private void OnDestroy()
        {
            _tween?.Kill();
        }

        private void Awake()
        {
            _tween = transform.DORotate(new Vector3(0, 0, -360), _rotationTime, RotateMode.LocalAxisAdd).SetEase(Ease.Linear).SetLoops(-1);
        }
    }
}
