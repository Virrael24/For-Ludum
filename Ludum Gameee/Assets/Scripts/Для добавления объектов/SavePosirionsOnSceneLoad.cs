using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePosirionsOnSceneLoad : MonoBehaviour
{
    public int LevelNumber;
    public List<Transform> Movable;

    private void OnEnable()
    {
        if(LevelNumber == 0 && ObjectPositions.MovableLevel1.Count != 0)
        {
            for (int i = 0; i < ObjectPositions.MovableLevel1.Count; i++) 
            {
                Movable[i].position = ObjectPositions.MovableLevel1[i];
            }
        }
    }
    public void Save()
    {
        if (LevelNumber == 0)
        {
            ObjectPositions.MovableLevel1 = new List<Vector3>();
            for (int i = 0; i < Movable.Count; i++)
            {
                ObjectPositions.MovableLevel1.Add(Movable[i].position);
            }
        }
    }
}
