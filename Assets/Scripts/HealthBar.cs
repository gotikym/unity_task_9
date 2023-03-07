using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private Player _player;

    private float _timeChange = 1f;

    private void OnEnable()
    {
        _player.ChangedHealth += OnChangedHealth;
    }

    private void OnDisable()
    {
        _player.ChangedHealth -= OnChangedHealth;
    }

    public void OnChangedHealth()
    {
        _healthBar.DOValue(_player.Health, _timeChange);
    }
}