using UnityEngine.UI;
using UnityEngine;

namespace Misc
{
    [RequireComponent(typeof(AudioSource))]
    public class AudioSystem : MonoBehaviour
    {
        public static AudioSystem Instance { get; private set; }

        [SerializeField] private AudioSource _audioSource;
        [SerializeField] private Slider _volumeSlider;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void Start()
        {
            UpdateSliderValue();
        }

        public void SetVolume(float volume) => _audioSource.volume = volume;
        public float GetVolume() => _audioSource.volume;

        public void UpdateSliderReference(Slider newSlider)
        {
            _volumeSlider = newSlider;
            UpdateSliderValue();
        }

        private void UpdateSliderValue()
        {
            _volumeSlider.value = _audioSource.volume;
            _volumeSlider.onValueChanged.AddListener(SetVolume);
        }
    }
}