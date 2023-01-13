using System.Collections;
using UnityEngine;

namespace Ivannuari
{
    public class GameMechanism : MonoBehaviour
    {
        public static GameMechanism Instance;

        public int totalTarget;
        public int sisaTarget;

        [SerializeField] private int totalHeart;
        private int sisaHeart;

        public Transform movingTarget;
        public enum GameplayState
        {
            STARTGAME,
            ENDGAME
        }
        public GameplayState GameState;

        public event HealthEventDelegate OnHealthChange;
        public delegate void HealthEventDelegate(int amount);


        public event GameplayStateDelegate OnGamePlayStateChange;
        public delegate void GameplayStateDelegate(GameplayState gameplayState);

        private void Awake()
        {
            if(Instance == null)
            {
                Instance = this;
            }
            else
            {
                return;
            }
        }

        private void Start()
        {
            sisaHeart = totalHeart;
            OnHealthChange?.Invoke(sisaHeart);
            OnGamePlayStateChange?.Invoke(GameplayState.STARTGAME);
        }

        public void GetDamage()
        {
            sisaHeart--;
            OnHealthChange?.Invoke(sisaHeart);

            if(sisaHeart <= 0)
            {
                OnGamePlayStateChange?.Invoke(GameplayState.ENDGAME);
            }
        }



        private void Update()
        {
            //test
            if (Input.GetKeyDown(KeyCode.P))
            {
                GetDamage();
            }
        }
    }
}