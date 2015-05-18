using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Windows.Forms;

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

    public static void ClearBoxes(Control control)
    {
        foreach (Control c in control.Controls)
        {
            var textBox = c as TextBox;
            var comboBox = c as ComboBox;

            if (textBox != null)
                (textBox).Clear();

            if (comboBox != null)
                comboBox.SelectedIndex = -1;

            if (c.HasChildren)
                ClearBoxes(c);
        }
    }

    

}