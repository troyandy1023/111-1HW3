# 第3次作業-作業-HW3
>
>學號：109111103
><br />
>姓名：曾昱翔
><br />
>作業撰寫時間：60 (mins，包含程式撰寫時間)
><br />
>最後撰寫文件日期：2022/10/25
>

本份文件包含以下主題：(至少需下面兩項，若是有多者可以自行新增)
- [x]說明內容
- [x]個人認為完成作業須具備觀念

## 說明程式與內容

開始寫說明，該說明需說明想法，
並於之後再對上述想法的每一部分將程式進一步進行展現，
若需引用程式區則使用下面方法，
若為.cs檔內程式除了於敘述中需註明檔案名稱外，
還需使用語法` ```csharp 程式碼 ``` `，
下段程式碼則為使用後結果：

```csharp
//建立陣列當作下拉式選單的選項
public partial class Test : System.Web.UI.Page
    {
        string[] ve = new string[2] { "蔬菜", "水果" };
        string[,] cc = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
//postback時判斷下拉式選單的選項
            if (!IsPostBack)
            {
                for(int ct = 0; ct < ve.Length; ct++)
                {
                    ListItem ol = new ListItem();
                    ol.Text = ol.Value = ve[ct];
                    ddl_Category.Items.Add(ol);
                }
                mt_GenSecondList();
            }
        }
//找出下拉式選單選定的項目
        protected void mt_GenSecondList()
        {
            int ind = ddl_Category.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int ct = 0; ct < cc.GetLength(1); ct++)
            {
                ListItem ol = new ListItem();
                ol.Text = ol.Value = cc[ind, ct];
                ddl_Food.Items.Add(ol);
            }
        }

        protected void ddl_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            mt_GenSecondList();
        }
    }
}
```

若要於內文中標示部分.aspx檔，則使用以下標籤` ```html 程式碼 ``` `，
下段程式碼則為使用後結果：

```html
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Test.aspx.cs" Inherits="_111_1HW3.Test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="ddl_Category" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddl_Category_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:DropDownList ID="ddl_Food" runat="server">
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>

```


## 個人認為完成作業須具備觀念

開始寫說明，需要說明本次作業個人覺得需學會那些觀念 (需寫成文章，需最少50字，
並且文內不得有你、我、他三種文字)

這次作業需要能夠了解下拉式選單裡的items陣列和裡面的元素，像是Value和Text，
再來還有for迴圈和PostBack的部分，充分了解這些觀念應該才是這次作業的重點。

