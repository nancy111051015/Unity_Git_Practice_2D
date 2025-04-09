using UnityEngine;

public class PlayerHealth
{
    public int MaxHealth = 100; // 玩家最大血量設定為100
    public int CurrentHealth; // 儲存目前血量

    public PlayerHealth()
    {
        CurrentHealth = MaxHealth; // 初始血量設為最大血量
    }

    public void TakeDamage(int amount) // 定義受傷的函式，參數是傷害值
    {
        CurrentHealth -= amount; // 扣掉傷害值
        CurrentHealth = Mathf.Max(CurrentHealth, 0); // 最低不能低於0，防止血量變成負數
    }


}
