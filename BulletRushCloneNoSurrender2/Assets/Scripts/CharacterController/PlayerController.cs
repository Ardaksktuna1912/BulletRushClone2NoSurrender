using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private ShootController _shootcont;
    [SerializeField] private ScreenTouchController _sc;
    [SerializeField] private Rigidbody _rb;
    [SerializeField] private float _speed;
    public void Move(Vector3 direction)
    {
        _rb.velocity = direction * _speed * Time.deltaTime;
    }


    private void Update()
    {
        var postemp = new Vector3(_sc.Direction.x, 0, _sc.Direction.y);
        Move(postemp);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Senemy" || other.gameObject.tag == "Benemy")
        {
            var direction = other.transform.position - transform.position;
            direction.y = 0;
            direction = direction.normalized;
            _shootcont.Shoot(direction, transform.position);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Senemy" || collision.gameObject.tag == "Benemy")
        {
            Dead();
        }
    }
    public void Dead()
    {
        Time.timeScale = 0;

    }

}
