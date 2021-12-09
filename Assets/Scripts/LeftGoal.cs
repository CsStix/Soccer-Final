using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeftGoal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            Debug.Log("GOAL!!!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
