using UnityEngine;

public class Enemy : MonoBehaviour
{
    private int hp;

    public void SetHp(int hpValue)
    {
        hp = hpValue;
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }

    public int GetHp()
    {
        return hp;
    }
}
