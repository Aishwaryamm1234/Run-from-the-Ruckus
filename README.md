# Run-from-the-Ruckus


Run-from-the-Ruckus is a 2D action-survival game built using Unity and C#. The player must escape from a chasing monster while navigating a dynamic environment filled with traps and obstacles.


## Features

- **Player Controls**: Move left/right and jump using keyboard input.
- **Monster AI**: The monster becomes faster and more aggressive over time.
- **Power-Ups**: Collect items for temporary boosts like speed and immunity.
- **Collisions**: Handles interaction between player, enemies, and traps.
- **Scene Management**: Includes main menu, gameplay, and transition screens.

## Tools Used

- **Unity** - Game engine for development and scene management.
- **C#** - Programming language for game logic and scripts.
- **Visual Studio** - IDE for coding and debugging.

## Screenshots

- Choosing the Player: `images/c![67c72aff-8154-4dc0-802d-2c1b28516b33](https://github.com/user-attachments/assets/0642357b-8ad1-4ede-a8ee-be6d2224b0c8)
hoose_player.png`
- Player Movement: `images/player_movement.png`
- Encountering Monster: `images/monster_encounter.png`
- Game Over: `images/player_destroyed.png`
- Game Assets: `images/game_assets.png`

## Code Snippets

**Player Movement**
```csharp
void PlayerMoveKeyBoard(){
    movementX = Input.GetAxisRaw("Horizontal");
    transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
}
