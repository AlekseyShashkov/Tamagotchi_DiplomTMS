using UnityEngine.UI;
using UnityEngine;

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
        _volumeSlider.value = _audioSource.volume;
        _volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    private void OnEnable()
    {
        _volumeSlider.value = _audioSource.volume;
        _volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    public void SetVolume(float volume)
    {
        if (_audioSource != null)
        {
            _audioSource.volume = volume;
        }
    }

    public void UpdateSliderReference(Slider newSlider)
    {
        _volumeSlider = newSlider;
        if (_volumeSlider != null)
        {
            _volumeSlider.value = _audioSource.volume;
            _volumeSlider.onValueChanged.AddListener(SetVolume);
        }
    }
}
