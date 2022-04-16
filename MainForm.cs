using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsformTest
{
    public partial class MainForm : Form
    {

        public int StoredNumber { get; set; }
        public int FirstStoredNumber { get; set; }
        public int SecondStoredNumber { get; set; }
        public int Result { get; set; }
        public string StoredOperand { get; set; }

        public decimal ResultDecimal { get; set; }
        public decimal RightDecimal { get; set; }
        public decimal LeftDecimal { get; set; }
        public bool IsBinary { get; set; }
        public bool IsDecimal { get; set; }
        public bool IsLoc { get; set; }
        public string BinaryStoredNumber { get; set; }
        public string FirstBinaryStoredNumber { get; set; }
        public string SecondBinaryStoredNumber { get; set; }
        public string DecimalNumber { get; set; }
        public List<int> BinaryNumbers { get; set; } 
        public MainForm()
        {
            ResultDecimal = 0m;
            RightDecimal = 0m;
            IsBinary = false;
            IsDecimal = false;
            IsLoc = false;
            LeftDecimal = 0m;
            StoredNumber = 0;
            SecondStoredNumber = 0;
            FirstStoredNumber = 0;
            StoredOperand = String.Empty;
            BinaryNumbers = new List<int> {128,64,32,16,8,4,2,1};
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Add)
            {
                Add_Click(sender, e);
            }
        }

        private void Subtract_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Subtract)
            {
                Subtract_Click(sender, e);
            }
        }

        private void Divide_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Divide)
            {
                Divide_Click(sender, e);
            }
        }

        private void Multiply_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Multiply)
            {
                Multiply_Click(sender, e);
            }
        }

        private void Subtract_Click(object sender, EventArgs e)
        {
            int i = 0;
            StoredOperand = "Minus";
            if (int.TryParse(textBox1.Text, out i) || textBox1.Text == "")
            {
                if (StoredNumber != 0 && StoredOperand != null && textBox1.Text != "")
                {
                    Equals_Click(sender, e);
                    StoredOperand = "Minus";
                } else
                {
                    if (StoredNumber != 0 && Result != 0)
                    {
                        Outcome.Text = $"{Result} -";
                        StoredNumber = Result;
                        textBox1.Text = "";
                    }
                    else
                    {
                        StoredNumber = int.Parse(textBox1.Text);
                        
                        Outcome.Text = $"{StoredNumber} -";
                        textBox1.Text = "";
                    }

                }
                textBox1.Text = "";
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            int i = 0;
            StoredOperand = "Plus";

            //Outcome.Text = (StoredNumber + int.Parse(textBox1.Text)).ToString();
            if (int.TryParse(textBox1.Text, out i) || textBox1.Text == "")
            {
                if (StoredNumber != 0 && StoredOperand != null && textBox1.Text != "")
                {
                    StoredOperand = "Plus";
                    Equals_Click(sender, e);
                }
                else
                {
                    if (StoredNumber != 0 && Result != 0)
                    {
                        Outcome.Text = $"{Result} +";
                        StoredNumber = Result;
                        textBox1.Text = "";
                    }
                    else
                    {
                        StoredNumber = int.Parse(textBox1.Text);
                        Outcome.Text = $"{StoredNumber} +";
                        textBox1.Text = "";
                    }
                }
                textBox1.Text = "";
            }
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            int i = 0;
            StoredOperand = "Divide";
            if (int.TryParse(textBox1.Text, out i) || textBox1.Text == "")
            {
                if (StoredNumber != 0 && StoredOperand != null && textBox1.Text != "")
                {
                    Equals_Click(sender, e);
                    StoredOperand = "Divide";
                }
                else
                {
                    if (StoredNumber != 0 && Result != 0)
                    {
                        Outcome.Text = $"{Result} /";
                        StoredNumber = Result;
                        textBox1.Text = "";
                    }
                    else
                    {
                        StoredNumber = int.Parse(textBox1.Text);
                        Outcome.Text = $"{StoredNumber} /";
                        textBox1.Text = "";
                    }
                }
                textBox1.Text = "";
            }
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            int i = 0;
            StoredOperand = "Multiply";
            if (int.TryParse(textBox1.Text, out i) || textBox1.Text == "")
            {
                if (StoredNumber != 0 && StoredOperand != null && textBox1.Text != "")
                {
                    Equals_Click(sender, e);
                    StoredOperand = "Multiply";
                    StoredOperand = "";
                }
                else
                {
                    if (StoredNumber != 0 && Result != 0)
                    {
                        Outcome.Text = $"{Result} *";
                        StoredNumber = Result;
                        textBox1.Text = "";
                    }
                    else
                    {
                        StoredNumber = int.Parse(textBox1.Text);
                        Outcome.Text = $"{StoredNumber} *";
                        textBox1.Text = "";
                    }
                }
                textBox1.Text = "";
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {

            if (StoredOperand == "Plus")
            {
                Result = StoredNumber + int.Parse(textBox1.Text);
                Outcome.Text = $"{StoredNumber} + {int.Parse(textBox1.Text)} = {Result}";
                FirstStoredNumber = StoredNumber;
                SecondStoredNumber = int.Parse(textBox1.Text);
                StoredNumber = Result;
                if (IsBinary)
                {
                    Bin_Click(sender, e);
                }
                else if(IsDecimal)
                {
                    Dec_Click(sender, e);
                } else if(IsLoc)
                {
                    Loc_Click(sender, e);
                }
                StoredOperand = "";
                textBox1.Text = "";
                
            } else if(StoredOperand == "Minus")
            {
                Result = StoredNumber - int.Parse(textBox1.Text);
                Outcome.Text = $"{StoredNumber} - {int.Parse(textBox1.Text)} = {Result}";
                SecondStoredNumber = int.Parse(textBox1.Text);
                StoredNumber = Result;
                if (IsBinary)
                {
                    Bin_Click(sender, e);
                }
                else if (IsDecimal)
                {
                    Dec_Click(sender, e);
                }
                else if (IsLoc)
                {
                    Loc_Click(sender, e);
                }
                StoredOperand = "";
                StoredOperand = "";
                textBox1.Text = "";
            }
            else if(StoredOperand == "Divide")
            {
                Result = StoredNumber/int.Parse(textBox1.Text);
                Outcome.Text = $"{StoredNumber} / {int.Parse(textBox1.Text)} = {Result}";
                SecondStoredNumber = int.Parse(textBox1.Text);
                StoredNumber = Result;
                if (IsBinary)
                {
                    Bin_Click(sender, e);
                }
                else if (IsDecimal)
                {
                    Dec_Click(sender, e);
                }
                else if (IsLoc)
                {
                    Loc_Click(sender, e);
                }
                StoredOperand = "";
                StoredOperand = "";
                textBox1.Text = "";
            }
            else if(StoredOperand == "Multiply")
            {
                Result = StoredNumber * int.Parse(textBox1.Text);
                Outcome.Text = $"{StoredNumber} * {int.Parse(textBox1.Text)} = {Result}";
                SecondStoredNumber = int.Parse(textBox1.Text);
                StoredNumber = Result;
                if (IsBinary)
                {
                    Bin_Click(sender, e);
                }
                else if (IsDecimal)
                {
                    Dec_Click(sender, e);
                }
                else if (IsLoc)
                {
                    Loc_Click(sender, e);
                }
                StoredOperand = "";
                StoredOperand = "";
                textBox1.Text = "";
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            StoredOperand = "";
            StoredNumber = 0;
            Result = 0;
            textBox1.Text = "";
            Outcome.Text = "0";
            Binary.Text = "Binary";
            IsBinary = false;
            IsDecimal = false;
            IsLoc = false;
        }

        private void Bin_Click(object sender, EventArgs e)
        {
            try
            {
                if(Result >= 1 && Result < 256)
                {
                    IsBinary = true;
                    IsLoc = false;
                    BinaryStoredNumber = "";
                    FirstBinaryStoredNumber = "";
                    SecondBinaryStoredNumber = "";
                    int newNum = Result;
                    int firstNum = FirstStoredNumber;
                    int secondNum = SecondStoredNumber;
                    for (int i = 0; i < BinaryNumbers.Count(); i++)
                    {
                        if (BinaryNumbers[i] <= newNum)
                        {
                            newNum -= BinaryNumbers[i];
                            BinaryStoredNumber += "1";
                        }
                        else
                        {
                            BinaryStoredNumber += "0";
                        }
                    }
                    for (int i = 0; i < BinaryNumbers.Count(); i++)
                    {
                        if (BinaryNumbers[i] <= firstNum)
                        {
                            firstNum -= BinaryNumbers[i];
                            FirstBinaryStoredNumber += "1";
                        }
                        else
                        {
                            FirstBinaryStoredNumber += "0";
                        }
                    }
                    for (int i = 0; i < BinaryNumbers.Count(); i++)
                    {
                        if (BinaryNumbers[i] <= secondNum)
                        {
                            secondNum -= BinaryNumbers[i];
                            SecondBinaryStoredNumber += "1";
                        }
                        else
                        {
                            SecondBinaryStoredNumber += "0";
                        }
                    }
                    //Result = Int32.Parse(BinaryStoredNumber);
                    if (Outcome.Text.Contains("+"))
                    {
                        Outcome.Text = $"{FirstBinaryStoredNumber} + {SecondBinaryStoredNumber} = {BinaryStoredNumber}";

                    }
                    else if(Outcome.Text.Contains("-"))
                    {
                        Outcome.Text = $"{FirstBinaryStoredNumber} - {SecondBinaryStoredNumber} = {BinaryStoredNumber}";

                    }
                    else if (Outcome.Text.Contains("/"))
                    {
                        Outcome.Text = $"{FirstBinaryStoredNumber} / {SecondBinaryStoredNumber} = {BinaryStoredNumber}";

                    }
                    else if (Outcome.Text.Contains("*"))
                    {
                        Outcome.Text = $"{FirstBinaryStoredNumber} * {SecondBinaryStoredNumber} = {BinaryStoredNumber}";

                    }
                    Binary.ForeColor = Color.Red;
                } else {
                    Console.WriteLine("Please use an 8 bit result between 1 and 255");
                }
               
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
            
        }

        private void Dec_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsBinary || IsLoc)
                {
                    IsBinary = false;
                    IsDecimal = true;
                    ResultDecimal = 0m;
                    RightDecimal = 0m;
                    LeftDecimal = 0m;
                    int DecimalNumberInt = 0;
                    int RightDecimalNumberInt = 0;
                    int LeftDecimalNumberInt = 0;
                    string DecimalStoredNumber = "";
                    string FirstDecimalBinaryStoredNumber = "";
                    string SecondDecimalBinaryStoredNumber = "";
                    var reverseString = BinaryStoredNumber.ToCharArray().Reverse().ToList();
                    var reverseLeftNumberString = FirstBinaryStoredNumber.ToCharArray().Reverse().ToList();
                    var reverseRightNumberString = SecondBinaryStoredNumber.ToCharArray().Reverse().ToList();
                    for (int i = 0; i < reverseString.Count(); i++)
                    {
                        Console.WriteLine(i);
                        if(reverseString[i].ToString() == "1")
                        {
                            DecimalNumberInt = (int)Math.Pow(2, i);
                            ResultDecimal += DecimalNumberInt;
                        }
                    }
                    for (int i = 0; i < reverseLeftNumberString.Count(); i++)
                    {
                        Console.WriteLine(i);
                        if (reverseLeftNumberString[i].ToString() == "1")
                        {
                            LeftDecimalNumberInt = (int)Math.Pow(2, i);
                            LeftDecimal += LeftDecimalNumberInt;
                        }
                    }
                    for (int i = 0; i < reverseRightNumberString.Count(); i++)
                    {
                        Console.WriteLine(i);
                        if (reverseRightNumberString[i].ToString() == "1")
                        {
                            RightDecimalNumberInt = (int)Math.Pow(2, i);
                            RightDecimal += RightDecimalNumberInt;
                        }
                    }
                    if (Outcome.Text.Contains("+"))
                    {
                        Outcome.Text = $"{LeftDecimal} + {RightDecimal} = {ResultDecimal}";

                    }
                    else if (Outcome.Text.Contains("-"))
                    {
                        Outcome.Text = $"{LeftDecimal} - {RightDecimal} = {ResultDecimal}";

                    }
                    else if (Outcome.Text.Contains("/"))
                    {
                        Outcome.Text = $"{LeftDecimal} / {RightDecimal} = {ResultDecimal}";

                    }
                    else if (Outcome.Text.Contains("*"))
                    {
                        Outcome.Text = $"{LeftDecimal} * {RightDecimal} = {ResultDecimal}";

                    }
                    Decimal.ForeColor = Color.Red;
                }
                else
                {
                    Console.WriteLine("Error! Please convert to Binary First");
                    Reset_Click(sender, e);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        private void Loc_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsDecimal || IsBinary)
                {
                    IsDecimal = false;
                    IsLoc = true;
                    string locString = "";
                    string locLeftString = "";
                    string locRightString = "";
                    string locStringResult = "";
                    int locNum = (int)ResultDecimal;
                    int locLeftNum = (int)LeftDecimal;
                    int locRightNum = (int)RightDecimal;
                    for (int i = 0; i < BinaryNumbers.Count(); i++)
                    {
                        var reverseLeftNumberString = FirstBinaryStoredNumber.ToCharArray().Reverse().ToList();
                        var reverseRightNumberString = SecondBinaryStoredNumber.ToCharArray().Reverse().ToList();
                        if (BinaryNumbers[i] <= locNum)
                        {
                            locNum -= BinaryNumbers[i];
                            if(BinaryNumbers[i] == 1)
                            {
                                locString += "a";
                            } else if(BinaryNumbers[i] == 2)
                            {
                                locString += "b";
                            }
                            else if (BinaryNumbers[i] == 4)
                            {
                                locString += "c";
                            }
                            else if (BinaryNumbers[i] == 8)
                            {
                                locString += "d";
                            }
                            else if (BinaryNumbers[i] == 16)
                            {
                                locString += "e";
                            } else if(BinaryNumbers[i] == 32)
                            {
                                locString += "f";
                            }
                            else if (BinaryNumbers[i] == 64)
                            {
                                locString += "g";
                            }
                            else if (BinaryNumbers[i] == 128)
                            {
                                locString += "h";
                            }
                            else if (BinaryNumbers[i] == 255)
                            {
                                locString += "1";
                            }
                        }
                        if (BinaryNumbers[i] <= locLeftNum)
                        {
                            locLeftNum -= BinaryNumbers[i];
                            if (BinaryNumbers[i] == 1)
                            {
                                locLeftString += "a";
                            }
                            else if (BinaryNumbers[i] == 2)
                            {
                                locLeftString += "b";
                            }
                            else if (BinaryNumbers[i] == 4)
                            {
                                locLeftString += "c";
                            }
                            else if (BinaryNumbers[i] == 8)
                            {
                                locLeftString += "d";
                            }
                            else if (BinaryNumbers[i] == 16)
                            {
                                locLeftString += "e";
                            }
                            else if (BinaryNumbers[i] == 32)
                            {
                                locLeftString += "f";
                            }
                            else if (BinaryNumbers[i] == 64)
                            {
                                locLeftString += "g";
                            }
                            else if (BinaryNumbers[i] == 128)
                            {
                                locLeftString += "h";
                            }
                            else if (BinaryNumbers[i] == 255)
                            {
                                locLeftString += "i";
                            }
                        }
                        if (BinaryNumbers[i] <= locRightNum)
                        {
                            locRightNum -= BinaryNumbers[i];
                            if (BinaryNumbers[i] == 1)
                            {
                                locRightString += "a";
                            }
                            else if (BinaryNumbers[i] == 2)
                            {
                                locLeftString += "b";
                            }
                            else if (BinaryNumbers[i] == 4)
                            {
                                locRightString += "c";
                            }
                            else if (BinaryNumbers[i] == 8)
                            {
                                locRightString += "d";
                            }
                            else if (BinaryNumbers[i] == 16)
                            {
                                locRightString += "e";
                            }
                            else if (BinaryNumbers[i] == 32)
                            {
                                locRightString += "f";
                            }
                            else if (BinaryNumbers[i] == 64)
                            {
                                locRightString += "g";
                            }
                            else if (BinaryNumbers[i] == 128)
                            {
                                locRightString += "h";
                            }
                            else if (BinaryNumbers[i] == 264)
                            {
                                locRightString += "i";
                            }
                        }
                    }
                    if (Outcome.Text.Contains("+"))
                    {
                        Outcome.Text = $"{locLeftString} + {locRightString} = {locString}";

                    }
                    else if (Outcome.Text.Contains("-"))
                    {
                        Outcome.Text = $"{locLeftNum} - {locRightNum} = {locString}";

                    }
                    else if (Outcome.Text.Contains("/"))
                    {
                        Outcome.Text = $"{locLeftNum} / {locRightNum} = {locString}";

                    }
                    else if (Outcome.Text.Contains("*"))
                    {
                        Outcome.Text = $"{locLeftNum} * {locRightNum} = {locString}";

                    }
                    Loc.ForeColor = Color.Red;
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public string LocBuilder(string test, int num)
        {
            
                if (num == 2)
                {
                    test += "a";
                }
                else if (num == 4)
                {
                    test += "b";
                }
                else if (num == 8)
                {
                    test += "c";
                }
                else if (num == 16)
                {
                    test += "d";
                }
                else if (num == 32)
                {
                    test += "e";
                }
                else if (num == 64)
                {
                    test += "f";
                }
                else if (num == 128)
                {
                    test += "g";
                }
                else if (num == 255)
                {
                    test += "h";
                }
           
            return test;
        } 
    }
}