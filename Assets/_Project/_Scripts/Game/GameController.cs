using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        [SerializeField] private ViewController _view;
        [SerializeField] private Misc.SceneLoader _sceneLoader;
        [SerializeField] private Misc.SaveLoadGame _saveLoadeGame;
        [SerializeField] private View.UIScreen _gameScreen;
        [SerializeField] private View.CustomButtonRepository _customButtonRepository;

        private Tamagotchi _tamagotchi;
        private CoinSpawner _coinSpawner;

        private void Start()
        {
            _tamagotchi = new Tamagotchi();

            _coinSpawner = _customButtonRepository.GetTamagotchiImage()
                .GetComponent<CoinSpawner>();

            _saveLoadeGame.Tamagotchi = _tamagotchi;
            _saveLoadeGame.CoinSpawner = _coinSpawner;

            _gameScreen.StartScreen();

            InitButtonListeners();
        }

        private void Update()
        {
            _tamagotchi.UpdateStates();
            _view.UpdateUI(_tamagotchi, _coinSpawner.CoinCounter);
        }

        private void InitButtonListeners()
        {
            _customButtonRepository.GetTamagotchiImage()
                .AddListener(() => _coinSpawner.SpawnCoin(_tamagotchi.Level.Lvl));

            _customButtonRepository.GetStateButtonRepository().GetHunger()
                .AddListener(_tamagotchi.Feed);
            _customButtonRepository.GetStateButtonRepository().GetDirty()
                .AddListener(_tamagotchi.Wash);
            _customButtonRepository.GetStateButtonRepository().GetFatigue()
                .AddListener(_tamagotchi.Sleep);
            _customButtonRepository.GetStateButtonRepository().GetSick()
                .AddListener(_tamagotchi.Treat);

            _customButtonRepository.GetSideBarButtonRepository().GetBack()
                .AddListener(MenuLoad);
            _customButtonRepository.GetSideBarButtonRepository().GetSave()
                .AddListener(_saveLoadeGame.SaveGame);
            _customButtonRepository.GetSideBarButtonRepository().GetLoad()
                .AddListener(_saveLoadeGame.LoadGame);
        }

        private void MenuLoad()
        {
            _gameScreen.CloseScreen();
            _sceneLoader.ChangeScene(Misc.SceneConstants.MENU_SCENE).Forget();
        }
    }
}