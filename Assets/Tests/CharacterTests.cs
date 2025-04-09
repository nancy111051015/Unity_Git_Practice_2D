using UnityEngine;
using NUnit.Framework;

public class CharacterTests
{
    [Test (Description = "玩家角色攻擊敵人")]
    public void Character_Attack_Enamy()
    {
        // arrange
        // 建立角色的元件
        var characterGo = new GameObject();
        characterGo.AddComponent<Character>();
        var character = characterGo.GetComponent<Character>();
        character.SetAtk(10);

        // 建立敵人的元件
        var enemyGo = new GameObject();
        enemyGo.AddComponent<Enemy>();
        var enemy = enemyGo.GetComponent<Enemy>();
        enemy.SetHp(hpValue: 100);

        // act
        character.Attack(enemy);

        // assert
        var hp = enemy.GetHp();
        Assert.AreEqual(expected: 90, actual: hp);
    }
}
