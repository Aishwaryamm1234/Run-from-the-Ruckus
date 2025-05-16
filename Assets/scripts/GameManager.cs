using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{


   public TextMeshProUGUI txt;
    

    public static GameManager instance;

    [SerializeField]
    private GameObject[] characters;

    private int _charIndex;
    public int CharIndex
    {
        get{ return _charIndex; }
        set{ _charIndex = value;}
        
    }
    public void Start()
    {
       
    }
    private void Awake(){
        if(instance == null)
        {
        instance=this;
        DontDestroyOnLoad(gameObject);
        }
       else
        {
            // If an instance already exists, destroy this GameObject
            
            
            Destroy(gameObject);
        }
    }
    
    private void OnEnable(){
        SceneManager.sceneLoaded += OnLevelFinishedLoading;
    }
    private void OnDisable(){
        SceneManager.sceneLoaded -= OnLevelFinishedLoading;
    }
    void OnLevelFinishedLoading(UnityEngine.SceneManagement.Scene scenes,LoadSceneMode mode){

      if(scenes.name == "gameplay 1") {
        Instantiate(characters[CharIndex]);
      }
 }


}