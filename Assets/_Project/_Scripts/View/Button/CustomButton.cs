using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace View
{
    [RequireComponent(typeof(Image))]
    public abstract class CustomButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        private readonly Color Pressed = new(0.1f, 0.1f, 0.1f);
        private Color _default = default;

        private Image _targetGraphic;
        private Vector2 _startScale = Vector2.zero;
        [SerializeField] private float _animationModificator = 1.1f;

        public Action _onClick = null;

        void OnEnable()
        {
            _targetGraphic = GetComponent<Image>();
            _default = _targetGraphic.color;

            _startScale = transform.localScale;
        }

        public void AddListener(Action onClick)
        {
            _onClick = onClick;
        }

        public void OnPointerDown(PointerEventData eventData)
        {
            _targetGraphic.color += Pressed;
            transform.localScale *= _animationModificator;

            _onClick?.Invoke();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _targetGraphic.color = _default;
            transform.localScale = _startScale;
        }

        void OnDisable()
        {
            _targetGraphic.color = _default;
            transform.localScale = _startScale;
        }

    }
}