 using System.Collections;
 using UnityEngine;
 using UnityEngine.SceneManagement;
 
 public class ClickSceneChange : MonoBehaviour
 {
     public float delay = 440;
     public string NewLevel= "TitleScreen";
     void Start()
     {
         StartCoroutine(LoadLevelAfterDelay(delay));
     }
 
     IEnumerator LoadLevelAfterDelay(float delay)
     {
         yield return new WaitForSeconds(delay);
         SceneManager.LoadScene(NewLevel);
    }
    void Update()
    {
        if(Input.anyKey) SceneManager.LoadScene(NewLevel);
    }
}