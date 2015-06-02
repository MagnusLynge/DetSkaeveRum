using System;

namespace Admin
{
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
            if (txtWord.Text != "")
            {
                if (word.CheckIfWordExists(txtWord.Text.ToUpper()) == false)
                {

                    lblStatus.Text = txtWord.Text.ToUpper() + " blev tilføjet!";

                    lblStatus.ForeColor = System.Drawing.Color.Green;



                    lblStatus.Visible = true;


                    word.CreateWord(wordForSubmit);
                }
                else
                {
                    lblStatus.Text = txtWord.Text.ToUpper() + " eksistere allerede!";
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Visible = true;

                }
            }
            else
            {
                lblStatus.ForeColor = System.Drawing.Color.Red;
                lblStatus.Text = "Tekst boksen er tom";
                lblStatus.Visible = true;
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
            lblStatus.Text = txtWord.Text.ToUpper() + " er slettet!";
            lblStatus.ForeColor = System.Drawing.Color.Red;
            lblStatus.Visible = true;

            txtWord.Text = String.Empty;
            lblAmountWordsCount.Text = word.CountAllWords().ToString();


        }
    }
}