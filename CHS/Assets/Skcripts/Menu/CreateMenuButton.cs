using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateMenuButton : MonoBehaviour
{

    public int scenForLoad;
   [SerializeField] private GameObject buttonPrefab;
    public GameObject spawnPoint;
    public GameObject currentButton;

    public void Awake()
    {
        scenForLoad = SceneManager.sceneCountInBuildSettings;
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < scenForLoad; i++)
        {
           currentButton = Instantiate(buttonPrefab, spawnPoint.transform);
            currentButton.GetComponent<SceneMumberLoad>().sceneNumber = i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
