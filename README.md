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

- Choosing the Player: ![image alt](https://github.com/Aishwaryamm1234/Run-from-the-Ruckus/blob/c8fe85b491dc5a244f483b3151c7e5db54d917da/Screenshot%202024-12-08%20135235.png)

  
- Player Movement: ![image alt](https://github.com/Aishwaryamm1234/Run-from-the-Ruckus/blob/5f52b59659aa2c5eee3ea98d025c0f0048f9bd81/WhatsApp%20Image%202025-05-16%20at%2010.42.57%20PM.jpeg)

  
- Encountering Monster: ![image alt](https://github.com/Aishwaryamm1234/Run-from-the-Ruckus/blob/5f52b59659aa2c5eee3ea98d025c0f0048f9bd81/Screenshot%202024-12-11%20151058.png)

  
- Game Over:![image alt](https://github.com/Aishwaryamm1234/Run-from-the-Ruckus/blob/5f52b59659aa2c5eee3ea98d025c0f0048f9bd81/WhatsApp%20Image%202025-05-16%20at%2010.43.34%20PM.jpeg)

  
- Game Assets:![image alt](https://github.com/Aishwaryamm1234/Run-from-the-Ruckus/blob/5f52b59659aa2c5eee3ea98d025c0f0048f9bd81/Screenshot%202024-12-08%20135809.png)

## Code Snippets

**Player Movement**
```csharp
void PlayerMoveKeyBoard(){
    movementX = Input.GetAxisRaw("Horizontal");
    transform.position += new Vector3(movementX, 0f, 0f) * Time.deltaTime * moveForce;
}
