using UnityEngine;

namespace ElbowGames
{
    public class Coin : MonoBehaviour
    {
        [field: SerializeField] public int AddedScore { get; private set; }
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.TryGetComponent(out ICollecting collector))
            {
                collector.AddScore(AddedScore);
                this.gameObject.SetActive(false);
            }

        }
    }
}
