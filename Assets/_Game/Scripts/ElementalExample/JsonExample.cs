using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace DefaultNamespace
{
    public class JsonExample : MonoBehaviour
    {
        [SerializeField] private ElementSO _element;

        private const string KEY = "my-test-key";
        
        [ContextMenu("Save")]
        public void SaveToDisk()
        {
            var jsonString = JsonUtility.ToJson(_element);

            PlayerPrefs.SetString(KEY, jsonString);
            PlayerPrefs.Save();
        }

        [ContextMenu("Load")]
        public void LoadFromDisk()
        {
            var savedJson = PlayerPrefs.GetString(KEY);
            JsonUtility.FromJsonOverwrite(savedJson, _element);
        }
        
        [ContextMenu("Load And Save As Asset")]
        public void LoadFromDiskAndSaveAsset()
        {
            Debug.Log("Loading and Saving As Asset");

            var savedJson = PlayerPrefs.GetString(KEY);
            var newElement = ScriptableObject.CreateInstance<ElementSO>();
            JsonUtility.FromJsonOverwrite(savedJson, newElement);
            
            //var newElement = JsonUtility.FromJson<ElementSO>(savedJson);

            var path = "Assets/_Game/Components/Elements/ElementFromDisk.asset";
            var asset = AssetDatabase.LoadAssetAtPath<ElementSO>(path);

            if (asset != null)
            {
                AssetDatabase.DeleteAsset(path);
            }
            
            AssetDatabase.CreateAsset(newElement, path);
            AssetDatabase.Refresh();
        }
    }
}
