using System.Collections.Generic;
using System.Linq;

namespace Game
{
    public class Tamagotchi
    {
        public static readonly string HUNGER_STATE = "HungerState";
        public static readonly string DIRTY_STATE = "DirtyState";
        public static readonly string FATIGUE_STATE = "FatigueState";
        public static readonly string SICK_STATE = "SickState";

        public Happy Happy { get; set; }
        public Level Level { get; set; }

        private Dictionary<string, IState> _states;

        public Tamagotchi()
        {
            SetStates(200.0f, 200.0f, 200.0f, 200.0f);

            float averageState = _states.Average(s => s.Value.State);
            float averageMaxState = _states.Average(s => s.Value.GetMaxState());

            Happy = new Happy(averageState, averageMaxState);
            Level = new Level();
        }

        public void Feed() => GetState(HUNGER_STATE).Modify(1000.0f);
        public void Wash() => GetState(DIRTY_STATE).Modify(1000.0f);
        public void Sleep() => GetState(FATIGUE_STATE).Modify(1000.0f);
        public void Treat() => GetState(SICK_STATE).Modify(1000.0f);

        public void UpdateStates()
        {
            foreach (KeyValuePair<string, IState> state in _states)
            {
                state.Value.Modify(state.Value.GetRandomDecreaseRate());
            }

            Happy.SetHappiness(_states.Average(s => s.Value.State));

            Level.UpExperience(Happy.GetHappinessCoef());
        }

        public IState GetState(string name)
        {
            return _states.GetValueOrDefault(name);
        }

        public void SetStates(float hungerState, float dirtyState, float fatigueState, float sickState)
        {
            _states = new Dictionary<string, IState>
            {
                {HUNGER_STATE, new HungerState(hungerState)},
                {DIRTY_STATE, new DirtyState(dirtyState)},
                {FATIGUE_STATE, new FatigueState(fatigueState)},
                {SICK_STATE,new SickState(sickState)}
            };
        }
    }
}