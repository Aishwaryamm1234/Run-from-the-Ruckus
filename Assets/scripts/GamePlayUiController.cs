using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamePlayUiController : MonoBehaviour
{
  public void RestartGame(){
   SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
  public void HomeButton(){
    SceneManager.LoadScene("mainmenu");
  }
}
