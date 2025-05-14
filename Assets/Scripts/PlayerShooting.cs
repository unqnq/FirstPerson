using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShooting : MonoBehaviour
{
    public GameObject[] bulletPrefabs;
    public int currentWeaponIndex = 0;
    public Transform firePoint;
    public float bulletSpeed = 20f;
    public float maxShootDistance = 100f;
    private Camera mainCamera;
    private void Awake()
    {
        mainCamera = Camera.main;
    }
    public void Shoot(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Shooting();
        }
    }

    void Shooting()
    {
        Ray ray = mainCamera.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        Vector3 shootDirection = ray.direction;

        GameObject bullet = Instantiate(bulletPrefabs[currentWeaponIndex], firePoint.position, Quaternion.LookRotation(shootDirection));
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.linearVelocity = shootDirection * bulletSpeed;
        }
    }

    public void UpgradeWeapon(GameObject newBulletPrefab)
    {
        for (int i = 0; i < bulletPrefabs.Length; i++)
        {
            if (bulletPrefabs[i].name == newBulletPrefab.name)
            {
                currentWeaponIndex = i;
                Debug.Log("Upgraded to " + bulletPrefabs[i].name);
                break;
            }
        }
    }

}
