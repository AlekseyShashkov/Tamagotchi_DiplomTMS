using UnityEngine;

namespace Game
{
    public class HungerState : IState
    {
        public float State { get; set; }

        public HungerState(float value)
        {
            State = value;
        }

        public float GetRandomDecreaseRate() => Random.Range(-8.0f, -3.0f);
    }
}