using UnityEngine;

namespace View
{
    public class MainMenu : UIScreen
    {
        [SerializeField] private CustomButton _startGame;
        [SerializeField] private CustomButton _settings;
        [SerializeField] private CustomButton _exit;
        [SerializeField] private UIScreen _settingsScreen;
        [SerializeField] private Misc.SceneLoader _sceneLoader;

        public override void SetupScreen(UIScreen previousScreen)
        {
            Debug.Log("Nothig to setup");
        }

        public override void StartScreen()
        {
            base.StartScreen();

            _startGame.AddListener(OpenGame);
            _settings.AddListener(Options);
            _exit.AddListener(Exit);
        }

        private void OpenGame()
        {
            CloseScreen();
            _sceneLoader.ChangeScene(Misc.SceneConstants.GAME_SCENE);
        }

        private void Options()
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