using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CharacterApp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IList<Characters> characters;

        IList<Questions> questions;

        public Questions currentQuestion { get; set; }

        PageViewModel pvm = new PageViewModel();

        public bool[] answerArray = new bool[Questions.All.Count];


        public MainPage()
        {
            InitializeComponent();
            questions = Questions.All;
            characters = Characters.All;
            questionListView.ItemsSource = questions;
            pvm.currentScore = 0;
        }
        

        
        private void True_Button_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var t = b.CommandParameter;
            int i = 0;

            foreach(Questions q in questions)
            {
                if(q.Text.Equals(t))
                {
                    answerArray[i] = true;
                }
                else
                {
                    i++;
                }
            }

            b.BackgroundColor = Xamarin.Forms.Color.LightBlue;
        }

        private void False_Button_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var t = b.CommandParameter;
            int i = 0;

            foreach (Questions q in questions)
            {
                if (q.Text.Equals(t))
                {
                    answerArray[i] = false;
                }
                else
                {
                    i++;
                }
            }

            b.BackgroundColor = Xamarin.Forms.Color.LightBlue;
        }

        private void List_Submit_Button_Clicked(object sender, EventArgs e)
        {
            for(int i = 0; i < questions.Count; i++)
            {
                if(answerArray[i]==true)
                {
                    pvm.currentScore += questions[i].TrueValue;
                }
                else if (answerArray[i] == false)
                {
                    pvm.currentScore += questions[i].FalseValue;
                }
            }

            foreach (Characters c in characters)
            {
                if (pvm.currentScore >= c.MinScore && pvm.currentScore <= c.MaxScore)
                {
                    mainLabel.Text = "You are " + c.Name;
                    mainImg.Source = c.Img;
                }
            }
            pvm.currentScore = 0;
        }

        async private void Button_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            await DisplayAlert("","Change","OK");
        }
    }
}
