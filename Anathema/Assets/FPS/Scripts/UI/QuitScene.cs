using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Unity.FPS.UI
{
    public class QuitScene : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void QuitGame()
        {
            Application.Quit();
            Debug.Log("Quitting...");
        }
    }
}