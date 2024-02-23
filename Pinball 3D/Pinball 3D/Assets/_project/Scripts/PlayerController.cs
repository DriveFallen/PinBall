using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator leftFlipper;
    [SerializeField] private Animator rightFlipper;
    [SerializeField] private Animator plunger;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
        {
            leftFlipper.SetTrigger("Push");
        }

        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            rightFlipper.SetTrigger("Push");
        }

        AnimatorStateInfo stateInfo = plunger.GetCurrentAnimatorStateInfo(0);

        if (Input.GetKey(KeyCode.Space))
        {
            if (stateInfo.normalizedTime < 0)
            {
                plunger.SetFloat("Direction", 0);
            }
            else
            {
                plunger.SetFloat("Direction", -1);
            }
        }
        else
        {
            if (stateInfo.normalizedTime > 1)
            {
                plunger.SetFloat("Direction", 0);
            }
            else
            {
                plunger.SetFloat("Direction", 1);
            }
        }
    }
}
