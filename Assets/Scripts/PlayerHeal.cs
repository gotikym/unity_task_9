using UnityEngine;

public class PlayerHeal : MonoBehaviour
{
    [SerializeField] private Player _player;

    private float _heal = 10f;

    public void OnButtonClick()
    {
        _player.TakeHeal(_heal);
    }
}
