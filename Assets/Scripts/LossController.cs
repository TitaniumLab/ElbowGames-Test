using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using Zenject;

namespace ElbowGames
{
    public class LossController : MonoBehaviour
    {
        [SerializeField] private float _lossDelay;
        [SerializeField] private RectTransform _lossScreen;
        [SerializeField] private int _menuSceneIndex;
        private Player _player;

        [Inject]
        private void Construct(Player player)
        {
            _player = player;
            _player.OnDamageTaken += Loss;
        }

        private async void Loss()
        {
            await Task.Delay((int)_lossDelay * 1000);
            _lossScreen.gameObject.SetActive(true);
            Time.timeScale = 0;
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
        public void LoadScene()
        {
            SceneManager.LoadScene(_menuSceneIndex);
            Time.timeScale = 1;
        }
    }
}
