using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Time.timeScale = 0;
        UIManager.Instance.ShowScore();
    }
}