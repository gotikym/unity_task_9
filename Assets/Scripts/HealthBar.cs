using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBarSlider;

    private float _maxValue = 100;
    private float _minValue = 0;
    private float _timeChange = 1f;
    private float _changeValue = 10;

    private float _currentValue;

    private void Start()
    {
        _currentValue = _maxValue;
    }

    public void Up()
    {
        if (_currentValue < _maxValue)
        {
            _currentValue += _changeValue;
            _healthBarSlider.DOValue(_currentValue, _timeChange);
        }
    }

    public void Down()
    {
        if (_currentValue > _minValue)
        {
            _currentValue -= _changeValue;
            _healthBarSlider.DOValue(_currentValue, _timeChange);
        }
    }
}