using UnityEngine;

public class MiniMapCamera : MonoBehaviour
{
    [SerializeField] GameObject player;

    void LateUpdate()
    {
        transform.position = new Vector3(player.transform.position.x, transform.position.y, player.transform.position.z);
    }
}
