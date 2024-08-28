using DG.Tweening;
using System.Threading.Tasks;
using UnityEngine;

namespace View
{
    [RequireComponent(typeof(CanvasGroup))]
    public abstract class UIScreen : MonoBehaviour
    {
        [SerializeField] private float _animationDuration = 0.2f;

        private CanvasGroup _canvasGroup;

        private void OnEnable()
        {
            _canvasGroup = GetComponent<CanvasGroup>();
        }

        public abstract void SetupScreen(UIScreen previousScreen);

        public virtual void StartScreen()
        {
            gameObject.SetActive(true);

            UpdateCanvasGroupProps(true, true, 1.0f);
        }

        public void CloseScreen()
        {
            CloseScreenWithAwait();
        }

        private async void CloseScreenWithAwait()
        {
            UpdateCanvasGroupProps(false, false, 0.0f);

            await Task.Delay((int)(_animationDuration * 1000.0f));

            gameObject.SetActive(false);
        }

        private void UpdateCanvasGroupProps(bool interactable, bool blocksRaycasts, float fadeEndValue)
        {
            _canvasGroup.interactable = interactable;
            _canvasGroup.blocksRaycasts = blocksRaycasts;
            _canvasGroup.DOKill();
            _canvasGroup.DOFade(fadeEndValue, _animationDuration);
        }
    }
}