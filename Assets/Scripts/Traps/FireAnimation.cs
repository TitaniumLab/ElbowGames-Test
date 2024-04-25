using DG.Tweening;
using UnityEngine;

namespace ElbowGames.Animations
{
    public class FireAnimation : MonoBehaviour
    {
        private Tween _tween;
        [SerializeField] private float _shakeTime = 1;
        [SerializeField] private float _strength = 1;
        [SerializeField] private int _vibrato = 10;
        [SerializeField] private float _randomness = 90;


        private void OnDestroy()
        {
            _tween?.Kill();
        }

        private void Awake()
        {
            _tween = transform.DOShakeScale(_shakeTime, _strength, _vibrato, _randomness, false).SetEase(Ease.Linear).SetLoops(-1);
        }
    }
}
