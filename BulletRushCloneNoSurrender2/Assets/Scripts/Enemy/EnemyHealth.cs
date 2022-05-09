using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{

    [SerializeField] private int _health;

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Bullet"))
        {
            _health -= 100;
            if (_health <= 0)
            {
                Die();
                other.gameObject.SetActive(false);

            }
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
