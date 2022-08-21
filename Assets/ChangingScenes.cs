using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangingScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeScene(string sceneName)
	{
		SceneManager.LoadScene (name);
	}
	public void Exit()
	{
		Application.Quit ();
	}
    
    
     public void LoadMainMenu()
     {  
         SceneManager.LoadScene(0);
     }
     public void LoadSelectLevel()
     {  
         SceneManager.LoadScene(1);
     }
     public void LoadGameProper()
     {  
         SceneManager.LoadScene(2);
     }
}
