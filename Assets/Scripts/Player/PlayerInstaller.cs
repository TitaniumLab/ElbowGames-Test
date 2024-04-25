using UnityEngine;
using Zenject;

namespace ElbowGames
{
    public class PlayerInstaller : MonoInstaller
    {
        [SerializeField] private Player _player;
        public override void InstallBindings()
        {
            Container.Bind<Player>().FromInstance(_player);

        }
    }
}