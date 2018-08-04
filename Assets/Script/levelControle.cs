using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelControle : MonoBehaviour {

	public void CarregaLevel(string levelNome)
    {
        SceneManager.LoadScene(levelNome);
    }
}
