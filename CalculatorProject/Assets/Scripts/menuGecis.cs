using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuGecis : MonoBehaviour
{
   public void sayfageciss(int sayfa_id)
{
    SceneManager.LoadScene(sayfa_id);
}
}
