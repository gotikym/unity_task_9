using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _health = 100;
    private float _maxHealth = 100;
    private float _minHealth = 0;

    public void TakeDamage(float valueChange)
    {
        if (_health > _minHealth)
        {
            _health -= valueChange;
        }

        _healthBar.ChangeBar(_health);
    }

    public void TakeHeal(float valueChange)
    {
        if (_health < _maxHealth)
        {
            _health += valueChange;
        }

        _healthBar.ChangeBar(_health);
    }
}
