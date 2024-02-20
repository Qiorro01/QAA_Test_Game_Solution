using Microsoft.VisualStudio.TestTools.UnitTesting;
using Player;
using System;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;

namespace ClassLibrary1
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private Player.PlayerCharacter _player;
        private Monster _monster;
        private Weapons _weapon;

        


        [Given(@"There is a new monster")]
        public void GivenThereIsANewMonster()
        {
            _monster = new Monster();
        }


        [Given(@"I a new player")]
        public void GivenIANewPlayer()
        {
            _player = new PlayerCharacter();
        }

        [When(@"I heal myself for (.*) dmg")]
        public void WhenIHealMyselfForDmg(int p0)
        {
            _player.Heal(p0);
        }


        [When(@"I take (.*) damage")]
        public void WhenITakeDamage(int p0)
        {
            _player.Hit(p0);
        }

        [Then(@"My health should now be (.*)")]
        public void ThenMyHealthShouldNowBe(int p0)
        {
            Assert.AreEqual(p0, _player.Health);

        }

        [Then(@"I should be (.*) dead")]
        public void ThenIShouldBeFalseDead(bool p0)
        {
            Assert.AreEqual(p0, _player.isDead);
        }


        //____________Newly Added section____________//

        [Given(@"I have a (.*) weapon")]
        public void GivenIHaveABoolWeapon(bool p0)
        {
            if (p0 == true) { _player.Weaponized(); }
        }

        [Given(@"We weapon is (.*) magic")]
        public void GivenWeWeaponIsBoolMagic(bool p0)
        {
            _weapon = new Weapons(1, 5);
            if (p0 == true) 
            {
                _weapon.MagicDamage();

            }
        }



        [When(@"I hit monster with magic weapon")]
        public void WhenIHitMonsterWithMagicWeapon()
        {
            int damage = 0;
            
            if (_player.hasWeapon == true)
            {
                damage = _player.Power + _weapon.WeaponPower;
            }

            _monster.Hit(damage);
        }



        [Then(@"Monster HP is (.*)")]
        public void ThenIDealMoreDamage(int p0)
        {
            Assert.AreEqual(p0,_monster.Health);
        }

    }
}
