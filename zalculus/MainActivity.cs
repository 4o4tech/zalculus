using Android.App;
using Android.Widget;
using Android.OS;




/*
 
build by jimze 
16/9/22    

 */
namespace zalculus
{
    [Activity(Label = "Zalculus", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {

        string text1 = null;
        string text2 = null;
        string operation = null;
        double num1 = 0;
        double num2 = 0;
        //double buffer = 0;
        bool flag = false;
        int length1 = 0;
        int length2 = 0;

        


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            //Button button = FindViewById<Button>(Resource.Id.myButton);
            Button button1 = FindViewById<Button>(Resource.Id.buttonOne);
            Button button2 = FindViewById<Button>(Resource.Id.buttonTwo);
            Button button3 = FindViewById<Button>(Resource.Id.buttonThree);
            Button button4 = FindViewById<Button>(Resource.Id.buttonFour);
            Button button5 = FindViewById<Button>(Resource.Id.buttonFive);
            Button button6 = FindViewById<Button>(Resource.Id.buttonSix);
            Button button7 = FindViewById<Button>(Resource.Id.buttonSeven);
            Button button8 = FindViewById<Button>(Resource.Id.buttonEight);
            Button button9 = FindViewById<Button>(Resource.Id.buttonNine);
            Button button0 = FindViewById<Button>(Resource.Id.buttonZero);
            Button buttonDot = FindViewById<Button>(Resource.Id.buttonDot);
            Button buttonPlus = FindViewById<Button>(Resource.Id.buttonPlus);
            Button buttonMinus = FindViewById<Button>(Resource.Id.buttonMinus);
            Button buttonMultiple = FindViewById<Button>(Resource.Id.buttonMultiple);
            Button buttonDevide = FindViewById<Button>(Resource.Id.buttonDevide);
            Button buttonEqual = FindViewById<Button>(Resource.Id.buttonEquel);
			Button buttonClear = FindViewById<Button>(Resource.Id.buttonClear);
			Button buttonAllClear = FindViewById<Button>(Resource.Id.buttonDele);

            TextView textbox = FindViewById<TextView>(Resource.Id.textView1);


            button1.Click += delegate
            {
                textbox.Text += "1";
                opflag(button1);
            };
            button2.Click += delegate
            {
                textbox.Text += "2";
                opflag(button2);
            };
            button3.Click += delegate
            {
                textbox.Text += "3";
                opflag(button3);

            };
            button4.Click += delegate
            {
                textbox.Text += "4";
                opflag(button4);

            };
            button5.Click += delegate
            {
                textbox.Text += "5";
                opflag(button5);

            };
            button6.Click += delegate
            {
                textbox.Text += "6";
                opflag(button6);

            };

            button7.Click += delegate
            {
                textbox.Text += "7";
                opflag(button7);

            };
            button8.Click += delegate
            {
                textbox.Text += "8";
                opflag(button8);

            };

            button9.Click += delegate
            {
                textbox.Text += "9";
                opflag(button9);

            };
            button0.Click += delegate
            {
                textbox.Text += "0";
                opflag(button0);
            };

            buttonDot.Click += delegate
            {
                textbox.Text += ".";

            };

            buttonMultiple.Click += delegate
            {

                textbox.Text += "*";

                opera(buttonMultiple);

            };
            buttonDevide.Click += delegate
            {

                textbox.Text += "/";

                opera(buttonDevide);

            };
            buttonPlus.Click += delegate
            {
                textbox.Text += "+";

                opera(buttonPlus);



            };
            buttonMinus.Click += delegate
            {
                textbox.Text += "-";

                opera(buttonMinus);

            };

            buttonEqual.Click += delegate
            {
                flag = false;
                textbox.Text += "=";

                num1 = whichOperator(operation);

                textbox.Text += num1;
                num2 = 0;

            };

			buttonClear.Click += delegate
		{
			textbox.Text = "";
			num1 = 0;
			num2 = 0;
			text1 = null;
			text2 = null;
			//buffer = 0;
			flag = false;
		};

			buttonAllClear.Click += delegate
		{
			if (flag == false)
			{
				textbox.Text = "";
				text1 = "0";
				num1 = 0;
				length1 = 0;
			}
			if (flag == true)
			{
				try
				{
					textbox.Text = textbox.Text.Remove(textbox.Text.Length - length2);
					text2 = "0";
					num2 = 0;
					length2 = 0;
				}
				catch
				{

				}

			}
		};


        }

        private double whichOperator(string operation)
        {
            switch (operation)
            {
                case "+":
                    num1 = num1+num2;
                    break;
                case "-":
                    num1 = num1-num2;
                    break;
                case "*":
                    num1 = num1 * num2;
                    break;
                case "/":
                    num1 = num1 / num2;
                    break;
            }

            return num1;
        }
        private string opera(object sender)
        {
            string str = (string)(((Button)sender).Text);


            if (flag == true)
            {
                num1 = whichOperator(str);
            }
            operation = str;
            flag = true;
            text1 = null;
            text2 = null;

            return str;
        }

        private void opflag(object sender)
        {

            string str = (string)(((Button)sender).Text);

            if (flag == false)
            {
                text1 += str;
                num1 = double.Parse(text1);
                length1 = text1.Length;
            }
            else
            {
                text2 += str;
                num2 = double.Parse(text2);
                length2 = text2.Length;
            }


        }
    }
}




