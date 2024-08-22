using UnityEngine;

namespace View
{
    public class Settings : UIScreen
    {
        [SerializeField] private CustomButton _back;

        private UIScreen _previousScreen;

        public override void SetupScreen(UIScreen previousScreen)
        {
            if (_previousScreen == null)
            {
                _previousScreen = previousScreen;
            }

            _back.AddListener(BackToMenu);
        }

        private void BackToMenu()
        {
            CloseScreen();
            _previousScreen.StartScreen();
        }
    }
}