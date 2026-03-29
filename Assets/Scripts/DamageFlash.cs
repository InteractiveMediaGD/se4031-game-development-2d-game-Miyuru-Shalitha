using UnityEngine;
using UnityEngine.UI;

public class DamageFlash : MonoBehaviour
{
    public Image flashImage;
    public float flashSpeed = 5f;

    private float alpha = 0f;

    void Update()
    {
        if (alpha > 0)
        {
            alpha -= Time.deltaTime * flashSpeed;
            flashImage.color = new Color(1, 0, 0, alpha);
        }
    }

    public void Flash()
    {
        alpha = 0.5f;
    }
}