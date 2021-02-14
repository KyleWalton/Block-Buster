using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public event Action<Player> onPlayerDeath;

    public int health = 3;

    void collidedWithEnemy(Enemy enemy)
    {
        enemy.Attack(this);
        if (health <= 0)
        {
            if (onPlayerDeath != null)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                //onPlayerDeath(this);
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
    }

    private void Update()
    {
        if (DataMutator.Instance.largeBall)
        {
            gameObject.transform.localScale = new Vector3(5, 5, 5);
        }

        if (DataMutator.Instance.ballColor == 0)
        { 
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(255, 0, 0);
        }

        if (DataMutator.Instance.ballColor == 1)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 0, 255);
        }

        if (DataMutator.Instance.ballColor == 2)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = new Color(0, 255, 0);
        }
    }
}
