using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDOL : MonoBehaviour
{
    // Start is called before the first frame update
    private Scene currentscene;
    void Awake()
    {
        currentscene = SceneManager.GetActiveScene();
        if (currentscene.name == "Preload")
        {
                 DontDestroyOnLoad(this);
                     SceneManager.LoadScene(1);
        }
      


    }

        
    
}
