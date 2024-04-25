using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ElbowGames.UI
{
    public class MainMenu : MonoBehaviour
    {
        [SerializeField] private int _playSceneIndex;
        [SerializeField] private Image _loadScreen;


        public async void LoadPlayScene()
        {

            _loadScreen.gameObject.SetActive(true);
            AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(_playSceneIndex);
            asyncLoad.allowSceneActivation = false;
            while (!asyncLoad.isDone)
            {
                if (asyncLoad.progress >= 0.9f)
                    asyncLoad.allowSceneActivation = true;
                await Task.Yield();
            }
        }
    }
}
