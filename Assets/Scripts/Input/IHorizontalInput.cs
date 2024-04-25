using System;

namespace ElbowGames.Input
{
    public interface IHorizontalInput
    {
        public event Action<float> OnHorizontalInput;
    }
}

