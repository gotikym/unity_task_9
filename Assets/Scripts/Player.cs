using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private UnityEvent _changedHealth;

    private float _maxHealth = 100;
    private float _minHealth = 0;

    public float Health { get; private set; }

    public event UnityAction OnChangedHealth
    {
        add => _changedHealth.AddListener(value);
        remove => _changedHealth.RemoveListener(value);
    }

    private void Start()
    {
        Health = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        Health = Mathf.Clamp(Health - damage, _minHealth, _maxHealth);
        _changedHealth?.Invoke();
    }

    public void TakeHeal(float heal)
    {
        Health = Mathf.Clamp(Health + heal, _minHealth, _maxHealth); ;
        _changedHealth?.Invoke();
    }
}