using UnityEngine;
using UnityEngine.Events;

public class LeftRightBorder : MonoBehaviour
{

    public UnityEvent OnBallCollide;

    private void OnCollisionEnter2D(Collision2D col) { OnBallCollide?.Invoke(); }

}
