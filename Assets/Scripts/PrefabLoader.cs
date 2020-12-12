using System.Collections.Generic;
using UnityEngine;
using System.IO;

public static class PrefabLoader
{
    // public static List<T> LoadAllPrefabsOfType<T>(string path) where T : MonoBehaviour
    // {
    //     if (path != "")
    //     {
    //         if (path.EndsWith("/"))
    //         {
    //             path = path.TrimEnd('/');
    //         }
    //     }

    //     DirectoryInfo dirInfo = new DirectoryInfo(path);
    //     FileInfo[] fileInf = dirInfo.GetFiles("*.prefab");

    //     //loop through directory loading the game object and checking if it has the component you want
    //     List<T> prefabComponents = new List<T>();
    //     foreach (FileInfo fileInfo in fileInf)
    //     {
    //         string fullPath = fileInfo.FullName.Replace(@"\","/");
    //         string assetPath = "Assets" + fullPath.Replace(Application.dataPath, "");
    //         GameObject prefab = AssetDatabase.LoadAssetAtPath(assetPath, typeof(GameObject)) as GameObject;

    //         if(prefab!= null)
    //         {
    //             T hasT = prefab.GetComponent<T>();
    //             if (hasT !=null)
    //             {
    //                 prefabComponents.Add(hasT);
    //             }
    //         }
    //     }
    //     return prefabComponents;
    // }

}