using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WordPage : System.Web.UI.Page
{
    WordForSession word = new WordForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        WordGrid.DataSource = word.GetAllWords();
        WordGrid.DataBind();

        RepeaterWord.DataSource = word.GetAllWords();
        RepeaterWord.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        var wordForSubmit = txtWord.Text;
        word.CreateWord(wordForSubmit);
        WordGrid.DataSource = word.GetAllWords();
        WordGrid.DataBind();

    }

    

}