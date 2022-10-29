#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEditor;
using UnityEngine;
using UnityEditor.SceneManagement;
using System.Threading;

public class DuktapePreview
{
    private const string TAG = "InitDuktape";
    private static string waitingScene = "wait";
    private static Scene targetScene;
    private static AsyncOperation loadTargetScene;

    [RuntimeInitializeOnLoadMethod]
    static void InitDuktapeMethod()
    {
        //Debug.LogError("DuktapePreview");
        EditorApplication.playModeStateChanged += EditorApplication_playModeStateChanged;
    }

    private static void EditorApplication_playModeStateChanged(PlayModeStateChange obj)
    {
        //ExitingPlayMode
        if (obj == PlayModeStateChange.ExitingPlayMode)
        {
            DukTapeVMManager.Instance.ShutDown();
        }
        //EnteredPlayMode
        if (obj == PlayModeStateChange.EnteredPlayMode)
        {
            targetScene = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            EditorSceneManager.LoadSceneAsync(waitingScene);
            loadTargetScene = EditorSceneManager.LoadSceneAsync(targetScene.name, LoadSceneMode.Single);
            loadTargetScene.allowSceneActivation = false;
            loadTargetScene.completed += LoadTargetScene_completed;
            DukTapeVMManager.Instance.Startup();
            EditorApplication.update += EditorUpdate;
        }
    }

    private static void LoadTargetScene_completed(AsyncOperation obj)
    {
        ParseJavaScript();
    }

    private static void EditorUpdate()
    {
        if (DukTapeVMManager.Instance.IsLoaded)
        {
            loadTargetScene.allowSceneActivation = true;
            EditorApplication.update -= EditorUpdate;
        }
       
    }
    private  static void ParseJavaScript()
    {
        var list = UnityEngine.SceneManagement.SceneManager.GetActiveScene().GetRootGameObjects();
        GameObject obj = null;
        //找到一个字节点最少的根节点
        foreach (var item in list)
        {
            if (item.transform.childCount==0)
            {
                obj = item;
                break;
            }
        }
        if (obj == null)
        {
            obj = list[0];
        }
        ARWorldEditor.SceneHierarchyUtility.SetExpandedRecursive(obj, true);

        //获取当前场景所有根节点
        foreach (GameObject rootObj in list)
        {
            ScriptRunner[] scriptRunners = rootObj.GetComponentsInChildren<ScriptRunner>(true);
         
            if (scriptRunners != null && scriptRunners.Length > 0)
            {
                for (int i = 0; i < scriptRunners.Length; i++)
                {
                    var sc = scriptRunners[i];
                    string root = Application.dataPath.Replace("/Assets", "");
                    string relativePath = AssetDatabase.GetAssetPath(sc.ScriptSource);
                    //Debug.LogError("root:"+ root + " relativePath:"+ relativePath);
                    sc.ParseScript(root, relativePath);
                }
            }
        }
        //Debug.Log("ParseJavaScript ok");
    }
}
#endif