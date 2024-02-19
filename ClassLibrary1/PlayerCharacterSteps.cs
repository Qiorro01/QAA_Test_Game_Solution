using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ClassLibrary1
{
    [Binding]
    public class PlayerCharacterSteps
    {
        private Player.PlayerCharacter _player;


        [Given(@"I a new player")]
        public void GivenIANewPlayer()
        {
            _player = new Player.PlayerCharacter();
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



    }
}
