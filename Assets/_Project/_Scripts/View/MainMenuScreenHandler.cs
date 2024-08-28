using UnityEngine;

namespace View
{
    public class MainMenuScreenHandler : MonoBehaviour
    {
        [SerializeField] private UIScreen _mainMenu;

        private void Start()
        {
            _mainMenu.StartScreen();
        }
    }
}