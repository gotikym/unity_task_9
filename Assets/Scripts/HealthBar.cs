using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBarSlider;

    private float _timeChange = 1f;

    private float _currentHealth;

    private void Start()
    {
        _currentHealth = _healthBarSlider.value;
    }

    public void TakeDamage(float valueChange)
    {
        if (_currentHealth > _healthBarSlider.minValue)
        {
            _currentHealth -= valueChange;
            _healthBarSlider.DOValue(_currentHealth, _timeChange);
        }
    }

    public void TakeHeal(float valueChange)
    {
        if (_currentHealth < _healthBarSlider.maxValue)
        {
            _currentHealth += valueChange;
            _healthBarSlider.DOValue(_currentHealth, _timeChange);
        }
    }
}