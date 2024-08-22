using UnityEngine;

namespace Game
{
    public interface IState
    {
        public float State { get; set; }

        public void Modify(float changeRate) => State = Mathf.Clamp(State + Time.deltaTime * changeRate, 0.0f, GetMaxState());

        public float GetMaxState() => 200.0f;

        public float GetRandomDecreaseRate();
    }
}