using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("chaos");
            StartBattle();
        }
    }
    public void StartBattle()
    {
        SceneManager.LoadScene("Battle");
    }
    public void EndBattle()
    {
        SceneManager.LoadScene("Turn");
    }
}
