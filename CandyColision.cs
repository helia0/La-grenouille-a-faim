using UnityEngine;

public class CandyCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("char_animations2_hd_0"))
        {
            Debug.Log("Toucher");
            Destroy(gameObject);
            
        }
    }
}
