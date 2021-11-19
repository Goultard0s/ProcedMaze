using UnityEngine;

public class Demo : MonoBehaviour
{

    [SerializeField] Timer timer;

    private void Start()
    {
        timer
        .SetDuration(25)
        .OnEnd(() => Debug.Log("Timer 4 ended"))
        .Begin();
    }

}