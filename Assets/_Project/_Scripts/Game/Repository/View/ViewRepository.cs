using TMPro;
using UnityEngine;

namespace Game
{
    public class ViewRepository : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _coins;

        private InformationViewRepository _informationViewRepository;
        private StateViewRepository _stateViewRepository;

        private void Awake()
        {
            _informationViewRepository = GetComponent<InformationViewRepository>();
            _stateViewRepository = GetComponent<StateViewRepository>();
        }
        
        public TextMeshProUGUI GetCoins() => _coins;

        public InformationViewRepository GetInformationViewRepository() => _informationViewRepository;
        public StateViewRepository GetStateViewRepository() => _stateViewRepository;
    }
}