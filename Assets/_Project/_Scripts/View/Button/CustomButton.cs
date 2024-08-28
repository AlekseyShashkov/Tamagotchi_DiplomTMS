using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace View
{
    [RequireComponent(typeof(Image))]
    [RequireComponent(typeof(AudioSource))]
    public abstract class CustomButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private readonly Color PressColor = new(0.1f, 0.1f, 0.1f);
        private readonly float AnimationModificator = 1.1f;
        
        private readonly float MaxVolume = 1.0f;

        [SerializeField] private AudioClip _clickSound;
        private AudioSource _audioSource;

        private Vector2 _startScale;
        private Color _default;
        private Image _targetGraphic;

        public Action _onClick;

        private void OnEnable()
        {
            _audioSource = GetComponent<AudioSource>();
            _audioSource.volume = Misc.AudioSystem.Instance == null 
                ? MaxVolume : Misc.AudioSystem.Instance.GetVolume();

            _targetGraphic = GetComponent<Image>();
            _default = _targetGraphic.color;

            _startScale = transform.localScale;
        }

        private void OnDisable()
        {
            SetDefaultValues();
        }

        public void AddListener(Action onClick)
        {
            _onClick = onClick;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _audioSource.PlayOneShot(_clickSound);

            _targetGraphic.color += PressColor;
            transform.localScale *= AnimationModificator;

            _onClick?.Invoke();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            SetDefaultValues();
        }

        private void SetDefaultValues()
        {
            _targetGraphic.color = _default;
            transform.localScale = _startScale;
        }
    }
}