using UnityEngine;

public class Drain : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject prefabBall;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            if (GameManager.BallCount > 0)
            {
                GameManager.BallCount -= 1;
                Instantiate(prefabBall).transform.position = spawnPoint.position;
            }
            else
            {
                Destroy(ExtraBall.extraBall);
                FindObjectOfType<GameManager>().GameOver();
            }
        }

        Destroy(other.gameObject, 0.5f);
    }
}