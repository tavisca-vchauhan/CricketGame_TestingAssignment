Feature: PlayerScore
	In order to enjoy cricket game
	As a player
	I want to be told my score

@mytag
Scenario: Player score is zero when game starts
	When Player starts a game of cricket
	Then the player score should be 0

Scenario: Player should be able to score runs
	Given Player has started a game of cricket
	When Player scores 1 runs
	Then the player score should be 1


Scenario: Player should be able to update his score
	Given Player has started a game of cricket
	Given Player has scored 1 runs
	When Player scores 3 runs
	Then the player score should be 4

Scenario: Player score will be zero
	Given Player has started a game of cricket
	Given Player has scored 4 runs
	Given Player gets out
	
