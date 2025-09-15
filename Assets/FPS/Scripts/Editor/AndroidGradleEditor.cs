using UnityEditor;
using UnityEditor.Android;
using UnityEngine;

using System.IO;

// https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Android.IPostGenerateGradleAndroidProject.OnPostGenerateGradleAndroidProject.html

class AndroidGradleEditor : IPostGenerateGradleAndroidProject
{
    public int callbackOrder { get { return 0; } }
    public void OnPostGenerateGradleAndroidProject(string path)
    {
        // AndroidGradleEditor.OnPostGenerateGradleAndroidProject at path /Users/hakimh/dev/github/unity/fps_sparse/build/android_studio/unityLibrary
        Debug.Log("AndroidGradleEditor.OnPostGenerateGradleAndroidProject at path " + path);

        // MonoScript script = MonoScript.FromMonoBehaviour(this);
        // string scriptPath = AssetDatabase.GetAssetPath(script);
        // Debug.Log("AndroidGradleEditor.OnPostGenerateGradleAndroidProject script: " + scriptPath);

        // AndroidGradleEditor.OnPostGenerateGradleAndroidProject currentDir: /Users/hakimh/dev/github/unity/fps_sparse
        // string currentDir = Directory.GetCurrentDirectory();
        // Debug.Log("AndroidGradleEditor.OnPostGenerateGradleAndroidProject currentDir: " + currentDir);
        // FileUtil.ReplaceDirectory("data/unityLibrary", path);
        string sparsePath = path + "/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/";
        FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/", sparsePath);

        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/", sparsePath);

        //FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_config.h", sparsePath + "spp_config.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_dlalloc.h", sparsePath + "spp_dlalloc.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_memory.h", sparsePath + "spp_memory.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_smartptr.h", sparsePath + "spp_smartptr.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_stdint.h", sparsePath + "spp_stdint.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_timer.h", sparsePath + "spp_timer.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_traits.h", sparsePath + "spp_traits.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp_utils.h", sparsePath + "spp_utils.h");
        // FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/external/sparsepp/spp.h", sparsePath + "spp.h");

        string utilsPath = path + "/src/main/Il2CppOutputProject/IL2CPP/libil2cpp/utils/";
        FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/libil2cpp/utils/Il2CppHashMap.h", utilsPath + "Il2CppHashMap.h");
        FileUtil.ReplaceFile("data/unityLibrary/src/main/Il2CppOutputProject/IL2CPP/libil2cpp/utils/Il2CppHashSet.h", utilsPath + "Il2CppHashSet.h");
    }
}