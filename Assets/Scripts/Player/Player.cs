using System;
using UnityEngine;

namespace ElbowGames
{
    public class Player : MonoBehaviour, IDamagable, ICollecting
    {
        public event Action OnDamageTaken;
        public event Action<int> OnScoreAdd;

        public void AddScore(int score)
        {
            OnScoreAdd?.Invoke(score);
        }

        public void TakeDamage()
        {
            OnDamageTaken?.Invoke();
        }
    }
}
