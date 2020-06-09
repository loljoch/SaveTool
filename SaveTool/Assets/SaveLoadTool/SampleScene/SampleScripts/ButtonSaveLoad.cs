using Common.SaveLoadSystem; //this is the namespace the tool is in
using UnityEngine;

public class ButtonSaveLoad : MonoBehaviour
{
    public void ExampleSave()
    {
        SaveLoadSystem.Save();
    }

    public void ExampleLoad()
    {
        SaveLoadSystem.Load();
    }
}
