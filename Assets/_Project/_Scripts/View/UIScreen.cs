using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

namespace View
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIScreen : MonoBehaviour
    {
        [SerializeField] private float _animationDuration = 0.3f;

        private CanvasGroup _screenUI;

        void OnEnable()
        {
            _screenUI = GetComponent<CanvasGroup>();
        }

        public abstract void SetupScreen(UIScreen previousScreen);

        public virtual void StartScreen()
        {
            gameObject.SetActive(true);

            _screenUI.interactable = true;
            _screenUI.blocksRaycasts = true;
            _screenUI.DOKill();
            _screenUI.DOFade(1.0f, _animationDuration);
        }

        public void CloseScreen()
        {
            CloseScreenWithAwait();
        }

        private async void CloseScreenWithAwait()
        {
            _screenUI.interactable = false;
            _screenUI.blocksRaycasts = false;
            _screenUI.DOKill();
            _screenUI.DOFade(0.0f, _animationDuration);

            await Task.Delay((int)(_animationDuration * 1000.0f));

            gameObject.SetActive(false);
        }
    }
}