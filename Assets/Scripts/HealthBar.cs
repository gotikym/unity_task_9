using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBarSlider;

    private float _timeChange = 1f;

    public void ChangeBar(float helth)
    {
        _healthBarSlider.DOValue(helth,_timeChange);
    }
}