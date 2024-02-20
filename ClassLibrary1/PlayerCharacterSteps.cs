using Microsoft.VisualStudio.TestTools.UnitTesting;
using Player;
using System;
using System.Diagnostics.Eventing.Reader;
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


        [Given(@"There is a monster")]
        public void GivenThereIsANewMonster()
        {
            _monster = new Monster();
            
        }

        [Given(@"There is a new (.*) monster")]
        public void GivenThereIsANewStringMonster(string p0)
        {
            if (p0 == "Gnome") { _monster.isGnome(); }
            else if (p0 == "Elf") { _monster.isElf(); }
            else if (p0 == "Ocr") { _monster.isOcr(); }
            else if (p0 == "Goblin") { _monster.isGoblin(); }
            else { _monster.isHuman(); }
        }


        [Given(@"I a new player")]
        public void GivenIANewPlayer()
        {
            _player = new PlayerCharacter();
        }

        [Given(@"I am a new (.*) player")]
        public void GivenIAmANewGnomePlayer(string p0)
        {
            if (p0 == "Gnome") { _player.isGnome(); }
            else if (p0 == "Elf") { _player.isElf(); }
            else if (p0 == "Ocr") { _player.isOcr(); }
            else if (p0 == "Goblin") { _player.isGoblin(); }
            else { _player.isHuman(); }

        }

        [Given(@"I have a (.*) weapon")]
        public void GivenIHaveABoolWeapon(bool p0)
        {
            if (p0 == true) { _player.Weaponized(); }
        }

        [Given(@"The weapon is (.*) magic")]
        public void GivenWeWeaponIsBoolMagic(bool p0)
        {
            _weapon = new Weapons(1, 5);
            if (p0 == true)
            {
                _weapon.MagicDamage();

            }
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

        [Then(@"(.*) Monster HP is (.*)")]
        public void ThenGoblinMonsterHPIs(string p0, int p1)
        {
            Assert.AreEqual(p1, _monster.Health);
            Assert.AreEqual("Goblin", _monster.Race);
        }

        
        
        [Then(@"I am a (.*) player")]
        public void ThenIAmAStringPlayer(string p0)
        {
            Assert.AreEqual(p0, _player.Race);
        }


    }
}
