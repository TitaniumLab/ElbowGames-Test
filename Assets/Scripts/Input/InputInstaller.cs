using UnityEngine;
using Zenject;
namespace ElbowGames.Input
{
    public class InputInstaller : MonoInstaller
    {
        [SerializeField] private MobileInput _mobileInput;
        public override void InstallBindings()
        {
            Container.Bind<IHorizontalInput>().FromInstance(_mobileInput);
            Container.Bind<IVerticalInput>().FromInstance(_mobileInput);
        }
    }
}