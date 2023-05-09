Requirements -
	Game must run -- complete
	Start Menu -- complete
	Options menu -- complete
	Two different audio -- menu and game have different music, also collisions trigger different audio based on object collided with
	Design Pattern -- Singleton - the level affects how quickly the bricks are dropped, i.e. the higher the level, the less time between bricks dropping. 

Bounties - 
	Levels -- implemented
	Level Design -- did not yet implement a level banner to flash across the screen when new level achieved (similar to 'Tetris')
		Environmental Hazards - falling bricks will end game
		Collide with beneficial effects - catching fuel cells increases game points
	Procedural Generation
		Random Parameters - bricks and fuel cells fall at random intervals
	Physics
		Gravity - bricks and fuel cells affected by gravity


Performance and Stability
	There is a bug where sometimes after crashing and restarting the game, the score count and audio affects do not restart, but the game play does proceed as normal. Other than that, the game is stable and playable, and does not crash.

=================================Update=========================
Pause menu added, but setting Time.deltaTime or Time.Time = 0 does not seem to freeze the game longer than a second. Not sure why, all sources I could find said this is the way to pause a game. 


This is an astroid like game where the player must avoid falling hazards, while collecting points. 
