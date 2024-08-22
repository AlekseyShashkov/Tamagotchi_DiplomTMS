using UnityEngine;

namespace Game
{
    public class SickState : IState
    {
        public float State { get; set; }

        public SickState(float value)
        {
            State = value;
        }

        public float GetRandomDecreaseRate() => Random.Range(-5.0f, -3.0f);
    }
}