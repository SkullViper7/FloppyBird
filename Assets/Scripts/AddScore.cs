using UnityEngine;

public class AddScore : MonoBehaviour
{
    /// <summary>
    /// Calling AddScore() method when the player goes through pipes.
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        UIManager.Instance.AddScore();
    }
}