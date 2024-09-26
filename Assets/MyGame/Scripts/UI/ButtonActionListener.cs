using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[AddComponentMenu("ThinhLe/ButtonActionListener")]

public class ButtonActionListener : MonoBehaviour
{

    public string scene;
    private Button button;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(UpdateLoadScene);
    }

    // Update is called once per frame
    void UpdateLoadScene()
    {
        SceneManager.LoadScene(scene);
    }

}
