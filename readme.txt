Requirements -
	Game must run -- complete
	Start Menu -- complete
	Options menu -- incomplete
	Two different audio -- menu and game have different music, also collisions trigger different audio based on object collided with
	Design Pattern -- Command

Bounties - 
	Levels -- attempted to implement levels, using time dilation, this caused bugs. The idea was that after so many points, the level would increase, and this would increase the speed of play
	Level Design -- did not yet implement a level banner to flash across the screen when new level achieved (similar to 'Tetris')
		Environmental Hazards - falling bricks will end game
		Collide with beneficial effects - catching fuel cells increases game points
	Procedural Generation
		Random Parameters - bricks and fuel cells fall at random intervals
	Physics
		Gravity - bricks and fuel cells affected by gravity


Performance and Stability
	There is a bug where sometimes after crashing and restarting the game, the score count and audio affects do not restart, but the game play does proceed as normal. Other than that, the game is stable and playable, and does not crash.


This is an astroid like game where the player must avoid falling hazards, while collecting points. 