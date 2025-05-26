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
<div align="center">
  ![Move](https://github.com/user-attachments/assets/06776afc-eb07-4eca-b25e-1a33ff3fb4aa)
</div>
<div align="center">
  ![2025-05-26 18-30-12](https://github.com/user-attachments/assets/1107157a-d0a7-434b-bc8e-fc69492086ac)
</div>
<div align="center">
  ![EnemyDeath](https://github.com/user-attachments/assets/171103c6-646f-4c6c-961a-c395f9aff242)
</div>
<div align="center">
 ![UpgradeWeapon](https://github.com/user-attachments/assets/8723dd67-1b7c-4875-90b4-8f33bfa6b068)
</div>
<div align="center">
 ![GameOver](https://github.com/user-attachments/assets/4a30a94b-c097-4949-92ff-2d742468f861)

</div>


