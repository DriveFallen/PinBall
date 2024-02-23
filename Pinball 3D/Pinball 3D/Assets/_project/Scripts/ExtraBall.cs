using UnityEngine;

public class ExtraBall : MonoBehaviour
{
    [SerializeField] private Transform ballSpawn;
    [SerializeField] private GameObject prefabBall;
    public static GameObject extraBall = null;

    private void OnTriggerEnter(Collider other)
    {
        if (extraBall == null)
        {
            extraBall = Instantiate(prefabBall);
            extraBall.transform.position = ballSpawn.position;
        }
    }
}