using System;
namespace ElbowGames.Input
{
    public interface IVerticalInput
    {
        public event Action<float> OnVerticalInput;
    }
}
