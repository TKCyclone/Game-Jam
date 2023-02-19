using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
   public TextMeshProUGUI wavesText;


   void OnEnable ()
   {
    wavesText.SetText(PlayerStats.Waves.ToString());
   }

   public void Replay ()
   {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }

   public void Menu ()
   {
        Debug.Log("Go to Menu");
   }
}
