using UnityEngine;

namespace ElbowGames
{
    public class Trap : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out IDamagable damagable))
                damagable.TakeDamage();
        }
    }
}
