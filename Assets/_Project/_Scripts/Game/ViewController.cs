using UnityEngine;

namespace Game
{
    public class ViewController : MonoBehaviour
    {
        [SerializeField] private ViewRepository _viewRepository;

        public void UpdateUI(Game.Tamagotchi tamagotchi, int coins)
        {
            _viewRepository.GetCoins().text = $"{coins}";

            _viewRepository.GetInformationViewRepository().GetLevel()
                .text = $"{tamagotchi.Level.Lvl} lvl";
            _viewRepository.GetInformationViewRepository().GetHappinies()
                .fillAmount = tamagotchi.Happy.GetHappinessCoef();
            _viewRepository.GetInformationViewRepository().GetExperience()
                .fillAmount = tamagotchi.Level.GetExperienceCoef();

            _viewRepository.GetStateViewRepository().GetHungerState()
                .fillAmount = tamagotchi.GetState(Game.Tamagotchi.HUNGER_STATE).GetStateCoef();
            _viewRepository.GetStateViewRepository().GetDirtyState()
                .fillAmount = tamagotchi.GetState(Game.Tamagotchi.DIRTY_STATE).GetStateCoef();
            _viewRepository.GetStateViewRepository().GetFatigueState()
                .fillAmount = tamagotchi.GetState(Game.Tamagotchi.FATIGUE_STATE).GetStateCoef();
            _viewRepository.GetStateViewRepository().GetSickState()
               .fillAmount = tamagotchi.GetState(Game.Tamagotchi.SICK_STATE).GetStateCoef();
        }
    }
}