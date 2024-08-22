using UnityEngine;

namespace Game
{
    public class DirtyState : IState
    {
        public float State { get; set; }

        public DirtyState(float value)
        {
            State = value;
        }

        public float GetRandomDecreaseRate() => Random.Range(-7.0f, -3.0f);
    }
}