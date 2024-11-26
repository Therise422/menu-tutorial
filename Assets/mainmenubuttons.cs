using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class mainmenubuttons : MonoBehaviour
{
   public void playGame()

   {
      SceneManager.LoadSceneAsync(1);
   }

   public void options()
   {
      
      Debug.Log("options");
   }

   public void exit()
   {
   #if UNITY_EDITOR
      EditorApplication.ExitPlaymode();
   #else
      Application.Quit();
   #endif
   }

}

