using System.IO;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu(fileName = "New Colors Database", menuName = "WaterSort/Database/Color/ColorsDatabase")]
public class ColorsDataBase : BaseDatabase
{
    public GenericDictionary<int, BaseItemColorDatabase> Database = new GenericDictionary<int, BaseItemColorDatabase>();
    protected override void LoadScriptableObject()
    {
#if UNITY_EDITOR
        _path = Path.Combine(Const.Path.PROJECT_FOLDER, Const.Path.PATH_SCRIPTOBJECT, _pathFolder);
        _pathAsset = Path.Combine(Const.Path.PATH_SCRIPTOBJECT, _pathFolder);
        var info = new DirectoryInfo(_path);
        var fileInfo = info.GetFiles("*" + Const.Prefix.ASSETS, SearchOption.AllDirectories);

        for (int i = 0; i < fileInfo.Length; i++)
        {
            BaseItemColorDatabase gameObject = (BaseItemColorDatabase)AssetDatabase.LoadAssetAtPath(_pathAsset + fileInfo[i].Name, typeof(BaseItemColorDatabase));
            if (gameObject == null)
            {
                Debug.Log("Get null", this);
                return;
            }
            gameObject.Model.Id = i;
            Database.Add(i, gameObject);
        }
#endif
    }

    protected override void SetDefaultValue()
    {
        _pathFolder = "Colors/Items/";
    }
}