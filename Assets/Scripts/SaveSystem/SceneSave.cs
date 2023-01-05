using System.Collections.Generic;

[System.Serializable]
public class SceneSave
{
    public Dictionary<string, bool> boolDictionary; // string key is  an identifier name 
    //string key is am identifier name we choose for this list
    public List<SceneItem> listSceneItem;
    public Dictionary<string, GridPropertyDetails> gridPropertyDetailsDictionary;
}

