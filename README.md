# 🔫 First-Person Shooter Game (Unity)

This is a **first-person shooter** game developed in Unity. The player must survive against waves of enemies that spawn around the edges of the game zone and relentlessly chase the player. Collect weapon upgrades and bonuses to improve your chances of survival and increase your score!

---

## 🎮 Gameplay Features

- **👁️ First-Person View:** Classic FPS (First-Person Shooter) perspective.  
- **🚶 Player Movement:** Full directional movement (WASD) with smooth camera control.  
- **👾 Enemy AI:**  
  - Enemies spawn at the borders of the arena.  
  - They chase and attack the player on contact.  
  - Two enemy types with different stats:
    - **Enemy A:** Slower, more health.
    - **Enemy B:** Faster, deals more damage.
- **❤️ Health System:**
  - The player has a health bar.
  - Damage is taken when enemies make contact.
  - Game over occurs when health reaches zero.
- **💥 Shooting Mechanics:**
  - Shoot in the direction you're facing (center of the screen).
  - Enemies take damage and die when health is depleted.
- **📈 Score System:**
  - Points awarded for each enemy killed.
  - Displayed on-screen UI.
- **⏱️ Increasing Difficulty:**
  - Enemy spawn rate increases over time, making the game more challenging.
- **🎁 Bonuses:**
  - Enemies have a chance (10–30%) to drop weapon upgrades.
  - New weapons have different projectile types and effects.
- **🔫 Weapon Upgrade System:**
  - You start with a default weapon (`BulletA`).
  - Upgrades drop sequentially: `BulletB`, `BulletC`, etc.
  - Pickups glow for better visibility.

---

## 🧩 Technical Overview

- **Engine:** Unity 6.1  
- **Language:** C#  
- **Core Scripts:**
  - `Bullet.cs` – Handles bullet behavior, damage dealing, and self-destruction
  - `EnemyAI.cs` – Controls enemy movement and attack logic
  - `EnemySpawner.cs` – Controls timed enemy spawning with scaling difficulty
  - `GameManager.cs` – Tracks score and manages game state  
  - `PlayerHealth.cs` – Manages player HP and damage  
  - `PlayerShooting.cs` – Handles shooting and projectile logic  
  - `WeaponPickUp.cs` – Allows picking up new weapons
  - `MouseLookController.cs` – Controls camera and player body rotation using mouse input (first-person view)
 


---

## 📺 GIFs / Previews



