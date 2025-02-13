using UnityEngine;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button_Sheet_Music.onClick.AddListener(On_Click_Button_Edit_Sheet_Music);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void On_Click_Button_Edit_Sheet_Music()
    {
        Scene_Manager.Instance.Change_Scene(Scene_Manager.SCENE_LIST.LOAD_SHEET_MUSIC);
    }

    public Button Button_Sheet_Music;
}
