using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms.VisualStyles;

public partial class WordPage : System.Web.UI.Page
{
    WordForSession word = new WordForSession();

    protected void Page_Load(object sender, EventArgs e)
    {

        RepeaterWord.DataSource = word.GetAllWords();
        RepeaterWord.DataBind();
        lblAmountWordsCount.Text = word.CountAllWords().ToString();
    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        var wordForSubmit = txtWord.Text.ToUpper();
        word.CreateWord(wordForSubmit);

        if (word.CheckIfWordExists(txtWord.Text.ToUpper()) == false)
        {
            lblWordAddedSuccess.Text= txtWord.Text.ToUpper() + " blev tilføjet!";
            
            lblWordAddedSuccess.Visible = true;
            lblWordAllreadyExists.Visible = false;
        }
        else if (word.CheckIfWordExists(txtWord.Text.ToUpper()) == true)
        {
            lblWordAllreadyExists.Text = txtWord.Text.ToUpper() + " eksistere allerede!";
            
            lblWordAllreadyExists.Visible = true;
            lblWordAddedSuccess.Visible = false;
        }


        RepeaterWord.DataSource = word.GetAllWords();
        RepeaterWord.DataBind();


        txtWord.Text = String.Empty;


        lblAmountWordsCount.Text = word.CountAllWords().ToString();
    }

    protected void btnDel_Click(object sender, EventArgs e)
    {
        var wordForDel = txtWord.Text.ToUpper();
        word.DeleteWord(wordForDel);
        RepeaterWord.DataSource = word.GetAllWords();
        RepeaterWord.DataBind();
        txtWord.Text = String.Empty;
        lblAmountWordsCount.Text = word.CountAllWords().ToString();


    }
}