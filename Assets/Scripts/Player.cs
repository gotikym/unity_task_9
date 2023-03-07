using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _changeHealth;

    private float _heal = 10f;
    private float _damage = 10f;
    private float _health = 100;
    private float _maxHealth = 100;
    private float _minHealth = 0;

    public float ConveyMeaningHealth()
    {
        return _health;
    }

    public void TakeDamage()
    {
        if (_health > _minHealth)
        {
            _health -= _damage;
            _changeHealth?.Invoke();
        }
    }

    public void TakeHeal()
    {
        if (_health < _maxHealth)
        {
            _health += _heal;
            _changeHealth?.Invoke();
        }
    }
}