using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Player _player;

    private float _damage = 10f;

    public void OnButtonClick()
    {
        _player.TakeDamage(_damage);
        _healthBar.TakeDamage(_damage);
    }
}