using UnityEngine;

public class Heal : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;
    [SerializeField] private Player _player;

    private float _heal = 10f;

    public void OnButtonClick()
    {
        _player.TakeHeal(_heal);
        _healthBar.TakeHeal(_heal);
    }
}
