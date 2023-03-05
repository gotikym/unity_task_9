using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _damage = 10f;

    public void OnButtonClick()
    {
        _player.TakeDamage(_damage);
    }
}