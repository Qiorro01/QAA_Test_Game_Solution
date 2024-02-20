Feature: Feature2

A short summary of the feature

Background: 
	Given I a new player
	Given There is a monster

@player_dmg
Scenario Outline: Health reduction
	When I take <damage> damage
	And I heal myself for <heal> dmg
	Then My health should now be <remainingHealth>
	And I should be <dead> dead
	
Examples: 
	| damage | remainingHealth | heal | dead  |
	| 0      | 100             | 0    | false |
	| 40     | 60              | 0    | false |
	| 50     | 70              | 20   | false |
	| 100    | 0               | 0    | true  |

@heal
Scenario: Overheal
When I heal myself for 100 dmg
Then My health should now be 100

@monster_dmg
Scenario: Adding weapon damage
    Given I have a true weapon
	And The weapon is true magic
	When I hit monster with magic weapon
	Then Monster HP is 75

@general_Mechanics
Scenario: Racial differences
Given I am a new Gnome player
Given There is a new Goblin monster
And I have a True weapon
Given The weapon is true magic
When I hit monster with magic weapon
Then Goblin Monster HP is 50
And I am a Gnome player

