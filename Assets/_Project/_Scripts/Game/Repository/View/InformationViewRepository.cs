using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
    public class InformationViewRepository : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _level;
        [SerializeField] private Image _experience;
        [SerializeField] private Image _happinies;

        public TextMeshProUGUI GetLevel() => _level;
        public Image GetExperience() => _experience;
        public Image GetHappinies() => _happinies;
    }
}