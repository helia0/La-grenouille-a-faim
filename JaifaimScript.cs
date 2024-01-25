using System.Collections;
using UnityEngine;

public class JaifaimScript : MonoBehaviour
{
    void Start()
    {
        // Assurez-vous que l'objet de jeu est activé au démarrage
        gameObject.SetActive(true);

        // Commence la coroutine pour détruire l'objet de jeu après 5 secondes
        StartCoroutine(DestroyAfterSeconds(5));
    }

    IEnumerator DestroyAfterSeconds(int seconds)
    {
        // Attendez le nombre spécifié de secondes
        yield return new WaitForSeconds(seconds);

        // Détruit l'objet de jeu
        Destroy(gameObject);
    }
}
