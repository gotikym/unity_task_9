using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBarSlider;
    [SerializeField] private Player _player;

    private float _timeChange = 1f;

    public void ChangeValue()
    {
        _healthBarSlider.DOValue(_player.ConveyMeaningHealth(), _timeChange);
    }
}