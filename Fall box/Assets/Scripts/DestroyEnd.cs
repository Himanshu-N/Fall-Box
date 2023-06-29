using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnd : MonoBehaviour
{
    public static bool _gameOver = false;
    [SerializeField] GameObject _prefabObject;


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log("Game Over");
            Debug.Log("Restarting in 3 seconds");
            _gameOver = true;
            Invoke("LoadScene", 3f);
        }
        if (other.gameObject.CompareTag("Player") && !_gameOver)
        {
            Instantiate(_prefabObject, new Vector2(Random.Range(-6, 6), 4f), Quaternion.identity);
            Destroy(gameObject);
        }

    }

    void LoadScene()
    {
        _gameOver = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
