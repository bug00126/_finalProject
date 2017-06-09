using UnityEngine;  
using System.Collections;  
using System.Collections.Generic;  
using UnityEngine.UI;  
  
public class ButtonsControl : MonoBehaviour  
{  
    //line render 相关  
    [Tooltip("Line renderer used for the line drawing.")]  
    public LineRenderer line;  
    public int lineVertexIndex = 2;

    public Text okButtonText;
    public GameObject window;
  
    //密码锁的按钮组  
    public Button[] btns;
    public Button btnOK;  
  
    //密码保存  
    public List<string> passwordCheck = new List<string>();
    private List<string> password = new List<string>();
  
    // Use this for initialization  
    void Start()  
    {  
        //绑定按钮事件，这里随便试了一个  
        for (int i = 0; i < btns.Length; i++)  
        {  
            UIEventListener btnListenser = btns[i].GetComponent<UIEventListener>();  
            btnListenser.OnMouseEnter += whenMouseEnter;  
            btnListenser.OnMouseDown += whenMouseDown;  
            //btnListenser.OnMouseExit += whenMouseExit;  
        }  
  
        UIEventListener btnokListenser = btnOK.GetComponent<UIEventListener>();  
        btnokListenser.OnClick += OnOKBtnClick;  
    }  
 
    #region 处理开始和结束  
    bool IsStart;
    bool isDone;
    void Update()  
    {
        isDone = checkIsDone();
        if (Input.GetMouseButton(0))  
        {  
            IsStart = true;  
        }  
        else  
        {  
            IsStart = false;  
        }  
    }  
    #endregion  

    bool checkIsDone () {
        for (int i=0; i<9; i++) {
            if (btns[i].interactable!=false)
                return false;
        }
        okButtonText.text = "Done";
        return true;
    }
  
    void whenMouseEnter(GameObject go)  
    {  
        if (IsStart == false)  
            return;  
  
        Debug.Log("enter button  " + go.name);  
        go.GetComponent<Image>().color = go.GetComponent<Button>().colors.highlightedColor;
  
        int i = int.Parse(go.name);  
  
        if (go.GetComponent<Button>().interactable) {
            go.GetComponent<Button>().interactable = false;
            password.Add(go.name);
            DrawLines(i - 1);
        }
    }  
 
    #region 处理意外  
    //处理鼠标按下时，刚好在按钮上的意外  
    void whenMouseDown(GameObject go)  
    {  
        IsStart = true;  
        whenMouseEnter(go);  
    }  
    #endregion  
  
    // 画按钮之间的连线  
    void DrawLines(int btnIndex)  
    {  
        if (line != null)  
        {  
            lineVertexIndex++;
            line.gameObject.SetActive(true);
            line.SetVertexCount(lineVertexIndex);  
  
            Vector3 cursorPos = btns[btnIndex].gameObject.transform.position;  
            cursorPos.z = 0f;  
 
            line.SetPosition(lineVertexIndex - 1, cursorPos);
        }  
    }  
  
    //输出设置的密码，可做后续处理，保存校对的啥的，可以继续延伸  
    void OnOKBtnClick(GameObject go)  
    {  
        string pass = "";  
        foreach (var item in password)  
        {  
            pass += item;  
        }  
  
        Debug.Log("the password you set is：" + pass);  

        if (isDone) {
            for (int i=0; i<9; i++) {
                if (password[i]!=passwordCheck[i]) {
                    for (int j=0; j<9; j++) {
                        btns[j].interactable = true;
                    }
                    line.SetVertexCount(0);
                    lineVertexIndex = 0;
                    password = new List<string>();
                    Debug.Log("wrong password");
                    break;
                }
                window.SetActive(false);
            }
        } else {
            for (int j=0; j<9; j++) {
                        btns[j].interactable = true;
            }
            line.SetVertexCount(0);
            lineVertexIndex = 0;
            password = new List<string>();
        }
    }  
}