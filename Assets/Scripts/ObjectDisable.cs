using UnityEngine;

public class ObjectDisable : MonoBehaviour
{
    /// <summary>
    /// Disabling objects when they collide with the target point.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        collision.gameObject.SetActive(false);
    }
}