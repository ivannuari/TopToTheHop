using UnityEngine;

[System.Serializable]
public class GameLevel
{
    public int levelNumber;
    public Sprite rewardIcon;
    public int rewardAmount;

    public LevelState levelState;
}


public enum LevelState
{
    NotReady,
    Ready,
    Complete
}