using UnityEngine;
using Zenject;

public class InputInstaller : MonoInstaller
{
    [SerializeField] private MobileInput _mobileInput;
    public override void InstallBindings()
    {
        Container.Bind<IHorizontalInput>().FromInstance(_mobileInput);
        Container.Bind<IVerticalInput>().FromInstance(_mobileInput);
    }
}