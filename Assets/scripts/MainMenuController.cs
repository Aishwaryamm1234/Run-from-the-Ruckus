using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
   public void PlayGame() {

    int selectedCharacter=
     int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
     
    GameManager.instance.CharIndex = selectedCharacter;
    SceneManager.LoadScene("gameplay 1");

   }
}


