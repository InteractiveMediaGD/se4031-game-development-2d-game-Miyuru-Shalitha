using UnityEngine;

public class ScoreTrigger : MonoBehaviour
{
    private bool scored = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!scored && collision.CompareTag("Player"))
        {
            scored = true;
            ScoreManager.instance.AddScore(1);
        }
    }
}