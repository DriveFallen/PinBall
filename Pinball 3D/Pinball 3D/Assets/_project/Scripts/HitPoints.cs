using UnityEngine;

public class HitPoints : MonoBehaviour
{
    [SerializeField] private int pointPerHit = 100;

    private void OnCollisionEnter(Collision collision)
    {
        GameManager.Score += pointPerHit;
    }
}