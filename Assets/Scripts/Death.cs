using UnityEngine;

public class Death : MonoBehaviour
{
    /// <summary>
    /// Stopping the time and displaying end screen when the bird hits a pipe or the ground.
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
        UIManager.Instance.ShowScore();
    }
}