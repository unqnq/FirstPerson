using UnityEngine;

public class WeaponPickUp : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            PlayerShooting playerShooting = other.gameObject.GetComponent<PlayerShooting>();
            if (playerShooting != null)
            {
                playerShooting.UpgradeWeapon(gameObject);
                Debug.Log("Weapon Picked Up: " + gameObject.name);
                Destroy(gameObject);
                
            }
        }
    }

    void Update()
    {
        transform.Rotate(0, 100 * Time.deltaTime, 0);
    }
}
