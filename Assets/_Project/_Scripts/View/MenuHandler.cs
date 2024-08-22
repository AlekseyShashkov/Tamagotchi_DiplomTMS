using UnityEngine;

namespace View
{
    public class MenuHandler : MonoBehaviour
    {
        [SerializeField] private UIScreen _mainMenu;

        private void Start()
        {
            _mainMenu.StartScreen();
        }
    }
}