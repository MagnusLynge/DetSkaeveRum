using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WordPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        WordGrid.DataSource = word.getAllWords();
        WordGrid.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        var newWord = txtWord.Text;
        word.InsertWord(newWord);
    }
}