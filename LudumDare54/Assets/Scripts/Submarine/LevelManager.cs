using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        if (Globals.portholeCount >= Globals.portholeRequired && Globals.periscopeCount >= Globals.periscopeRequired && Globals.pipeFixed && Globals.wallFixed && Globals.antennaFixed)
        {
            FinishLevel();
        }
    }

    private IEnumerator FinishLevel()
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("Conclusion");
        yield return 0;
    }
}
