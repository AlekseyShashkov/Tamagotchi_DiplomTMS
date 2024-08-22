using UnityEngine;

namespace Game
{
    public class GameController : MonoBehaviour
    {
        [Header("Controllers")]
        [SerializeField] private ViewController _viewController;
        [SerializeField] private Misc.SceneLoader _sceneLoader;

        [Space, Header("Buttons")]
        [SerializeField] private View.CustomButton _tamagotchiImage;
        [Header("Buttons state")]
        [SerializeField] private View.CustomButton _hunger;
        [SerializeField] private View.CustomButton _dirty;
        [SerializeField] private View.CustomButton _fatigue;
        [SerializeField] private View.CustomButton _sick;
        [Header("Buttons side bar")]
        [SerializeField] private View.CustomButton _back;
        [SerializeField] private View.CustomButton _save;
        [SerializeField] private View.CustomButton _load;

        private Tamagotchi _tamagotchi;
        private CoinSpawner _coinSpawner;
        private Misc.SaveLoadGame _saveLoadeGame;

        private void Start()
        {
            _tamagotchi = new Tamagotchi();

            _coinSpawner = _tamagotchiImage.GetComponent<CoinSpawner>();
            _coinSpawner.TamagotchiLevel = _tamagotchi.Level;

            _saveLoadeGame = GetComponent<Misc.SaveLoadGame>();
            _saveLoadeGame.Tamagotchi = _tamagotchi;
            _saveLoadeGame.CoinSpawner = _coinSpawner;

            _tamagotchiImage.AddListener(_coinSpawner.SpawnCoin);

            _hunger.AddListener(_tamagotchi.Feed);
            _dirty.AddListener(_tamagotchi.Wash);
            _fatigue.AddListener(_tamagotchi.Sleep);
            _sick.AddListener(_tamagotchi.Treat);

            _back.AddListener(() => _sceneLoader.ChangeScene(Misc.SceneConstants.MENU_SCENE));
            _save.AddListener(_saveLoadeGame.SaveGame);
            _load.AddListener(_saveLoadeGame.LoadGame);
        }

        private void Update()
        {
            _tamagotchi.UpdateState();
            _viewController.UpdateUI(_tamagotchi, _coinSpawner.CoinCounter);
        }
    }
}