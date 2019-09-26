using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace App1
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        int score = 0;
        public MainPage()
        {
            InitializeComponent();
            #region Visible
            question2.IsVisible = false;
            question3.IsVisible = false;
            question4.IsVisible = false;
            question5.IsVisible = false;
            question6.IsVisible = false;
            question7.IsVisible = false;
            question8.IsVisible = false;
            question9.IsVisible = false;
            question10.IsVisible = false;
            question11.IsVisible = false;
            question12.IsVisible = false;
            question13.IsVisible = false;
            question14.IsVisible = false;
            question15.IsVisible = false;
            question16.IsVisible = false;
            question17.IsVisible = false;
            question18.IsVisible = false;
            question50.IsVisible = false;
            scoreframe.IsVisible = false;
            #endregion
            lblDeviceName.Text = "Welcome : " + DeviceInfo.Name + " at my Quiz !";
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }      
        #region Question 1
        private void Question1Answer1_Clicked(object sender, EventArgs e)
        {
            question1.IsVisible = false;
            question2.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
            
        }
        private void Question1Answer2_Clicked(object sender, EventArgs e)
        {
            question1.IsVisible = false;
            question2.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Question1Answer1_Clicked_1(object sender, EventArgs e)
        {
            question1.IsVisible = false;
            question2.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Question1Answer2_Clicked_1(object sender, EventArgs e)
        {
            question1.IsVisible = false;
            question2.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 2
        private void LightningMods_Q2(object sender, EventArgs e)
        {
            question2.IsVisible = false;
            question3.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void DEFAULTDNBQ2(object sender, EventArgs e)
        {
            question2.IsVisible = false;
            question3.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void LapyQ2(object sender, EventArgs e)
        {
            question2.IsVisible = false;
            question3.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void SpecterQ2(object sender, EventArgs e)
        {
            question2.IsVisible = false;
            question3.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 3
        private void Q160Q3(object sender, EventArgs e)
        {
            question3.IsVisible = false;
            question4.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q200Q3(object sender, EventArgs e)
        {
            question3.IsVisible = false;
            question4.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q176Q3(object sender, EventArgs e)
        {
            question3.IsVisible = false;
            question4.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q170Q3(object sender, EventArgs e)
        {
            question3.IsVisible = false;
            question4.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 4
        private void DUHTQ4(object sender, EventArgs e)
        {
            question4.IsVisible = false;
            question5.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void DUHDQ4(object sender, EventArgs e)
        {
            question4.IsVisible = false;
            question5.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void CUHQ4(object sender, EventArgs e)
        {
            question4.IsVisible = false;
            question5.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void DECRQ4(object sender, EventArgs e)
        {
            question4.IsVisible = false;
            question5.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 5
        private void Q450Q5(object sender, EventArgs e)
        {
            question5.IsVisible = false;
            question6.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q550Q5(object sender, EventArgs e)
        {
            question5.IsVisible = false;
            question6.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q600Q5(object sender, EventArgs e)
        {
            question5.IsVisible = false;
            question6.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q150Q5(object sender, EventArgs e)
        {
            question5.IsVisible = false;
            question6.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 6
        private void m0rph3us1987Q6(object sender, EventArgs e)
        {
            question6.IsVisible = false;
            question7.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void AlAzifQ6(object sender, EventArgs e)
        {
            question6.IsVisible = false;
            question7.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void TheFloWQ6(object sender, EventArgs e)
        {
            question6.IsVisible = false;
            question7.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void SPECTQWERTQ6(object sender, EventArgs e)
        {
            question6.IsVisible = false;
            question7.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 7
        private void SilicaQ7(object sender, EventArgs e)
        {
            question7.IsVisible = false;
            question8.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void MrNiatoQ7(object sender, EventArgs e)
        {
            question7.IsVisible = false;
            question8.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void LapyQ7(object sender, EventArgs e)
        {
            question7.IsVisible = false;
            question8.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void DEFAULTDNBQ7(object sender, EventArgs e)
        {
            question7.IsVisible = false;
            question8.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 8
        private void DECQ8(object sender, EventArgs e)
        {
            question8.IsVisible = false;
            question9.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void FEBQ8(object sender, EventArgs e)
        {
            question8.IsVisible = false;
            question9.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void MAYQ8(object sender, EventArgs e)
        {
            question8.IsVisible = false;
            question9.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void OCTQ8(object sender, EventArgs e)
        {
            question8.IsVisible = false;
            question9.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 9
        private void JAN10Q9(object sender, EventArgs e)
        {
            question9.IsVisible = false;
            question10.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void JAN18Q9(object sender, EventArgs e)
        {
            question9.IsVisible = false;
            question10.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void JAN28Q9(object sender, EventArgs e)
        {
            question9.IsVisible = false;
            question10.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void JAN24Q9(object sender, EventArgs e)
        {
            question9.IsVisible = false;
            question10.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 10
        private void Q0x199Q10(object sender, EventArgs e)
        {
            question10.IsVisible = false;
            question11.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void LightningMods_Q10(object sender, EventArgs e)
        {
            question10.IsVisible = false;
            question11.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void GregQ10(object sender, EventArgs e)
        {
            question10.IsVisible = false;
            question11.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void PSXHAXQ10(object sender, EventArgs e)
        {
            question10.IsVisible = false;
            question11.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 11
        private void Q0x199Q11(object sender, EventArgs e)
        {
            question11.IsVisible = false;
            question12.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void LightningMods_Q11(object sender, EventArgs e)
        {
            question11.IsVisible = false;
            question12.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void GregQ11(object sender, EventArgs e)
        {
            question11.IsVisible = false;
            question12.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void PSXHAXQ11(object sender, EventArgs e)
        {
            question11.IsVisible = false;
            question12.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 12
        private void Q0x199Q12(object sender, EventArgs e)
        {
            question12.IsVisible = false;
            question13.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void LightningMods_Q12(object sender, EventArgs e)
        {
            question12.IsVisible = false;
            question13.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void GregQ12(object sender, EventArgs e)
        {
            question12.IsVisible = false;
            question13.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void PSXHAXQ12(object sender, EventArgs e)
        {
            question12.IsVisible = false;
            question13.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 13
        private void JANQ13(object sender, EventArgs e)
        {
            question13.IsVisible = false;
            question14.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void FEBQ13(object sender, EventArgs e)
        {
            question13.IsVisible = false;
            question14.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void MARCHQ13(object sender, EventArgs e)
        {
            question13.IsVisible = false;
            question14.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void APRQ13(object sender, EventArgs e)
        {
            question13.IsVisible = false;
            question14.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 14
        private void Q11Q14(object sender, EventArgs e)
        {
            question14.IsVisible = false;
            question15.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q20Q14(object sender, EventArgs e)
        {
            question14.IsVisible = false;
            question15.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q24Q14(object sender, EventArgs e)
        {
            question14.IsVisible = false;
            question15.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q26Q14(object sender, EventArgs e)
        {
            question14.IsVisible = false;
            question15.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 15
        private void MrNiatoQ15(object sender, EventArgs e)
        {
            question15.IsVisible = false;
            question16.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Z80Q15(object sender, EventArgs e)
        {
            question15.IsVisible = false;
            question16.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void ZECOQ15(object sender, EventArgs e)
        {
            question15.IsVisible = false;
            question16.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q0X199Q15(object sender, EventArgs e)
        {
            question15.IsVisible = false;
            question16.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 16
        private void MrNiatoQ16(object sender, EventArgs e)
        {
            question16.IsVisible = false;
            question17.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Z80Q16(object sender, EventArgs e)
        {
            question16.IsVisible = false;
            question17.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void ZECOQ16(object sender, EventArgs e)
        {
            question16.IsVisible = false;
            question17.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void Q0X199Q16(object sender, EventArgs e)
        {
            question16.IsVisible = false;
            question17.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 17
        private void ZECOQ17(object sender, EventArgs e)
        {
            question17.IsVisible = false;
            question18.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void ZER0Q17(object sender, EventArgs e)
        {
            question17.IsVisible = false;
            question18.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void DEFAULTQ17(object sender, EventArgs e)
        {
            question17.IsVisible = false;
            question18.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void CELESTEQ17(object sender, EventArgs e)
        {
            question17.IsVisible = false;
            question18.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 18
        private void FATQ18(object sender, EventArgs e)
        {
            question18.IsVisible = false;
            question19.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void SLIMQ18(object sender, EventArgs e)
        {
            question18.IsVisible = false;
            question19.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void ULTRAQ18(object sender, EventArgs e)
        {
            question18.IsVisible = false;
            question19.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void PROQ18(object sender, EventArgs e)
        {
            question18.IsVisible = false;
            question19.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion
        #region Question 19
        private void KURTQ20(object sender, EventArgs e)
        {
            question20.IsVisible = false;
            question21.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void ZECOQ20(object sender, EventArgs e)
        {
            question20.IsVisible = false;
            question21.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void BISOONQ20(object sender, EventArgs e)
        {
            question20.IsVisible = false;
            question21.IsVisible = true;
            score = score + 1;
            DisplayAlert("Information", "Good answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        private void IMCSXQ20(object sender, EventArgs e)
        {
            question20.IsVisible = false;
            question21.IsVisible = true;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
        }
        #endregion



        #region Question 50
        private void Fire30Q50(object sender, EventArgs e)
        {
            question50.IsVisible = false;
            scoreframe.IsVisible = true;
            DisplayAlert("Information", "Good answer !", "Ok");
            score = score + 1;
            scorelabelingame.Text = "Here is your score : " + score.ToString() + " /10";
            scorelabelingame.IsVisible = false;
            scorelabel.Text = "Here is your score : " + score.ToString() + " /10";
            if (score == 10)
            {
                DisplayAlert("Information", "Congratulation !\n10/10\nYou're the best !", "Ok");
            }
            if (score == 9)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're almost there ! Keep Trying !", "Ok");
            }
            if (score >= 6 && score <= 8)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Nice try but you can do a better score !", "Ok");
            }
            if (score >= 3 && score <= 5)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Not very good... !", "Ok");
            }
            if (score >= 0 && score <= 2)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're really bad....", "Ok");
            }
        }
        private void MathieuQ50(object sender, EventArgs e)
        {
            question50.IsVisible = false;
            scoreframe.IsVisible = true;
            scorelabelingame.IsVisible = false;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabel.Text = "Here is your score : " + score.ToString() + " /10";
            if (score == 9)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're almost there ! Keep Trying !", "Ok");
            }
            if (score >= 6 && score <= 8)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Nice try but you can do a better score !", "Ok");
            }
            if (score >= 3 && score <= 5)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Not very good... !", "Ok");
            }
            if (score >= 0 && score <= 2)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're really bad....", "Ok");
            }
        }
        private void SpecterQ50(object sender, EventArgs e)
        {
            question50.IsVisible = false;
            scoreframe.IsVisible = true;
            scorelabelingame.IsVisible = false;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabel.Text = "Here is your score : " + score.ToString() + " /10";
            if (score == 9)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're almost there ! Keep Trying !", "Ok");
            }
            if (score >= 6 && score <= 8)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Nice try but you can do a better score !", "Ok");
            }
            if (score >= 3 && score <= 5)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Not very good... !", "Ok");
            }
            if (score >= 0 && score <= 2)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're really bad....", "Ok");
            }
        }
        private void AlAzifQ50(object sender, EventArgs e)
        {
            question50.IsVisible = false;
            scoreframe.IsVisible = true;
            scorelabelingame.IsVisible = false;
            DisplayAlert("Information", "Incorrect answer !", "Ok");
            scorelabel.Text = "Here is your score : " + score.ToString() + " /10";
            if (score == 9)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're almost there ! Keep Trying !", "Ok");
            }
            if (score >= 6 && score <= 8)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Nice try but you can do a better score !", "Ok");
            }
            if (score >= 3 && score <= 5)
            {
                DisplayAlert("Information", score.ToString() + "/10\n Not very good... !", "Ok");
            }
            if (score >= 0 && score <= 2)
            {
                DisplayAlert("Information", score.ToString() + "/10\n You're really bad....", "Ok");
            }
        }
        #endregion
    }
}
