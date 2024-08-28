using UnityEngine;

namespace View
{
    public class CustomButtonRepository : MonoBehaviour
    {
        [SerializeField] private CustomButton _tamagotchiImage;

        private StateButtonRepository _stateButtonRepository;
        private SideBarButtonRepository _sideBarButtonRepository;

        private void Awake()
        {
            _stateButtonRepository = GetComponent<StateButtonRepository>();
            _sideBarButtonRepository = GetComponent<SideBarButtonRepository>();
        }

        public CustomButton GetTamagotchiImage() => _tamagotchiImage;

        public StateButtonRepository GetStateButtonRepository() => _stateButtonRepository;
        public SideBarButtonRepository GetSideBarButtonRepository() => _sideBarButtonRepository;
    }
}