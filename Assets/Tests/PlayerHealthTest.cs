using NUnit.Framework; // 測試框架
using UnityEngine;

public class PlayerHealthTest
{
    [Test] // 告訴 Unity，下面的 function 是一個測試
    
    public void Player_TakesDamage_HealthDecreases() // 測試受傷後，血量是否正確扣除
    {
        PlayerHealth player = new PlayerHealth(); // 建立玩家物件
        player.TakeDamage(30); // 給予30傷害
        Assert.AreEqual(70, player.CurrentHealth); // 測試結果是否為預期值（100-30=70）
    }

    [Test] 
    public void Player_HealthDoesNotGoNegative() // 防止血量變成負數
    {
        PlayerHealth player = new PlayerHealth(); 
        player.TakeDamage(150); // 給予超過最大血量的傷害
        Assert.AreEqual(0, player.CurrentHealth); // 確認血量最小為0，不會是負數
    }

}
