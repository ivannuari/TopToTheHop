using System.Collections;
using UnityEngine;

namespace Ivannuari
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager Manager;

        public int levelNumber;
        public int totalCoin;

        private void Awake()
        {
            if(Manager == null)
            {
                Manager = this;
            }
            else
            {
                Destroy(gameObject);
            }
            DontDestroyOnLoad(gameObject);
        }
    }
}