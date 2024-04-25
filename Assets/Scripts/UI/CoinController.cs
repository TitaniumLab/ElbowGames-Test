using TMPro;
using UnityEngine;
using Zenject;

namespace ElbowGames.UI
{
    public class CoinController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _scoreText;
        [SerializeField] private int _totalScore = 0;
        private Player _player;

        [Inject]
        private void Constuct(Player player)
        {
            _player = player;
            _player.OnScoreAdd += AddScpre;
        }


        private void AddScpre(int score)
        {
            _totalScore += score;
            _scoreText.text = _totalScore.ToString();
        }
    }
}
