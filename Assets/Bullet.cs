using UnityEngine;

public class Bullet : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        var hit = collision.gameObject;
        var hitCombat = hit.GetComponent<Combat>();
         Debug.Log("OnCollisionEnter => collision " + hit.name);
        if (hitCombat != null)
        {
             Debug.Log("OnCollisionEnter => hitCombat" + hitCombat.name);
            hitCombat.TakeDamage(10);
            Destroy(gameObject);
        }
    }
}