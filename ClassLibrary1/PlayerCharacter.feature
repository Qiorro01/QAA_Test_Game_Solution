Feature: Feature2

A short summary of the feature

Background: 
	Given I a new player

@dmg
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