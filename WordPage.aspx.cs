using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class WordPage : System.Web.UI.Page
{
    WordForSession wrd = new WordForSession();

    protected void Page_Load(object sender, EventArgs e)
    {
        WordGrid.DataSource = wrd.GetAllWords();
        WordGrid.DataBind();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
    }

    

}