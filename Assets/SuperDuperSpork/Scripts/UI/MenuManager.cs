using UnityEngine;
using System.Collections;

namespace SpaceGame.UI
{

    public class MenuManager : MonoBehaviour
    {

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void joinGame()
        {
            Debug.Log("Join Game - I DO NOTHING YET");
        }

        public void exitGame()
        {
            Application.Quit();
            Debug.Log("Exit");
        }
    }
}
