using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Game
{
    public class ViewController : MonoBehaviour
    {
        [Header("Text counters")]
        [SerializeField] private TextMeshProUGUI _coins;
        [SerializeField] private TextMeshProUGUI _level;

        [Space, Header("Tamagotchi information")]
        [SerializeField] private Image _experience;
        [SerializeField] private Image _happinies;

        [Space, Header("Tamagotchi states")]
        [SerializeField] private Image _hungerState;
        [SerializeField] private Image _dirtyState;
        [SerializeField] private Image _fatigueState;
        [SerializeField] private Image _sickState;

        public void UpdateUI(Game.Tamagotchi tamagotchi, int coins)
        {
            _coins.text = $"{coins}";
            _level.text = $"{tamagotchi.Level.Lvl} lvl";

            _happinies.fillAmount = tamagotchi.Happy.Happiness / tamagotchi.Happy.MaxHappiness;
            _experience.fillAmount = tamagotchi.Level.Experience / tamagotchi.Level.MaxExperience;

            _hungerState.fillAmount = Amount(tamagotchi.GetState(Game.Tamagotchi.HUNGER_STATE));
            _dirtyState.fillAmount = Amount(tamagotchi.GetState(Game.Tamagotchi.DIRTY_STATE));
            _fatigueState.fillAmount = Amount(tamagotchi.GetState(Game.Tamagotchi.FATIGUE_STATE));
            _sickState.fillAmount = Amount(tamagotchi.GetState(Game.Tamagotchi.SICK_STATE));
        }

        private float Amount(Game.IState tamagotchiState) => tamagotchiState.State / tamagotchiState.GetMaxState();
    }
}