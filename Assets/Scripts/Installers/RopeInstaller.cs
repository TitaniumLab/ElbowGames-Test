using UnityEngine;
using Zenject;

public class RopeInstaller : MonoInstaller
{
    [SerializeField] private RopeSpawner _ropeSpawner;
    public override void InstallBindings()
    {
        Container.Bind<RopeSpawner>().FromInstance(_ropeSpawner);
    }
}