Feature: TwoPlayerScore
	In order to enjoy cricket game
	As a player
	I want to be told the winner between two players

@mytag
Scenario: Both Players score is zero when game starts
	When Player1 starts a game of cricket
	Then the player1 score should be 0
	

Scenario: Players ending up the game at Tie
	When Player1 starts a game of cricket
	Given player1 has scored 2 runs	
	Given player1 scores 6 runs
	Given player1 scores 2 runs
	Given player1 scores 3 runs
	Given player1 got out
	Given player2 scores 6 runs
	Given player2 scores 2 runs
	Given player2 scores 4 runs
	Given player2 scores 1 runs
	When player2 gets out
	Then Match tied

Scenario: Player1 wins the game
	Given Player1 starts a game of cricket
	Given player1 has scored 4 runs	
	Given player1 scores 2 runs
	Given player1 scores 3 runs
	Given player1 got out
	Given player2 scores 2 runs
	Given player2 scores 3 runs
	Given player2 scores 1 runs
	When player2 gets out
	Then player1 is the winner

Scenario: Player2 wins the game 
	Given Player1 starts a game of cricket
	Given player1 has scored 4 runs	
	Given player1 scores 1 runs
	Given player1 scores 3 runs
	Given player1 scores 2 runs
	Given player1 got out
	Given player2 scores 2 runs
	Given player1 scores 1 runs
	Given player1 scores 2 runs
	Given player1 scores 3 runs
	When player2 scores 4 runs
	Then player2 is the winner

Scenario: Player2 wins the game without getting out
	Given Player1 starts a game of cricket
	Given player1 has scored 1 runs	
	Given player1 scores 1 runs
	Given player1 scores 3 runs
	Given player1 got out
	Given player2 scores 2 runs
	When player2 scores 4 runs
	Then player2 is the winner

Scenario: Player1 wins the game without getting out
	Given Player2 starts a game of cricket
	Given player2 has scored 1 runs	
	Given player2 scores 6 runs
	Given player2 scores 3 runs
	Given player2 got out
	Given player1 scores 2 runs
	Given player1 scores 3 runs
	Given player1 scores 4 runs
	When player1 scores 4 runs
	Then player1 is the winner


Scenario: Player2 can score multiple times
	Given player2 has scored 8 runs	
	When player2 scores 1 runs
	Then the player2 score should be 9


