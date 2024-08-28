using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class StateViewRepository : MonoBehaviour
    {
        [SerializeField] private Image _hungerState;
        [SerializeField] private Image _dirtyState;
        [SerializeField] private Image _fatigueState;
        [SerializeField] private Image _sickState;

        public Image GetHungerState() => _hungerState;
        public Image GetDirtyState() => _dirtyState;
        public Image GetFatigueState() => _fatigueState;
        public Image GetSickState() => _sickState;
    }
}