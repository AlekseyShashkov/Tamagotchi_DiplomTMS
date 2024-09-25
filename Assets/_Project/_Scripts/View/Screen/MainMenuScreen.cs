using TMPro;
using UnityEngine;

namespace View
{
    public class MainMenuScreen : UIScreen
    {
        [SerializeField] private UIScreen _settingsScreen;

        [SerializeField] private Misc.SceneLoader _sceneLoader;

        [Space, Header("Buttons")]
        [SerializeField] private CustomButton _startGame;
        [SerializeField] private CustomButton _settings;
        [SerializeField] private CustomButton _exit;

        [Space, Header("Title parameters")]
        [SerializeField] private TextMeshProUGUI _title;
        [SerializeField] private Color _startColor;
        [SerializeField] private Color _endColor;
        private float _timer = 0.0f;

        private void Update()
        {
            _timer += Time.deltaTime % 2.0f;

            _title.color = Color.Lerp(_startColor, _endColor, Mathf.PingPong(_timer, 1.0f));
        }

        public override void SetupScreen(UIScreen previousScreen)
        {
            Debug.LogError("Nothig to setup");
        }

        public override void StartScreen()
        {
            base.StartScreen();

            _startGame.AddListener(OpenGame);
            _settings.AddListener(Settings);
            _exit.AddListener(Exit);
        }

        private void OpenGame()
        {
            CloseScreen();
            _sceneLoader.ChangeScene(Misc.SceneConstants.GAME_SCENE).Forget();
        }

        private void Settings()
        {
            _settingsScreen.SetupScreen(this);

            CloseScreen();
            _settingsScreen.StartScreen();
        }

        private void Exit()
        {
            CloseScreen();
            Application.Quit();
        }
    }
}