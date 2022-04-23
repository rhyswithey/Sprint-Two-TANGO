using System;
using System.Windows.Forms;

namespace SPRINT_TWO
{
    public partial class TangoInc : Form
    {
        //set the array including size, set sorted boolean

        public TangoInc()
        {
            InitializeComponent();
        }
        static int maxArraySize = 24;
        int[] myNumbers = new int[maxArraySize];
        bool Sorted = false;

        // Set the array values randomly (10-99) Random(); feature
        private void initiliseArray()
        {
            Random random = new Random();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                myNumbers[x] = random.Next(10, 100);
            }
        }
        //Send the array calues to the listbox (Arraybox)
        private void displayArray()
        {
            Arraybox.Items.Clear();
            for (int x = 0; x < myNumbers.Length; x++)
            {
                Arraybox.Items.Add(myNumbers[x]);
            }
        }


        private void inputbox_TextChanged(object sender, EventArgs e)
        {

        }
        // Use binary search to find users input. Display found or a error message
        private void findbutton_Click(object sender, EventArgs e)
        {
            int minNum = 0;
            int maxNum = myNumbers.Length;
            int key = int.Parse(inputbox.Text);
            // user sorts find chops list and seaches until found
            while (minNum <= maxNum)
            {
                int mid = (minNum + maxNum) / 2;
                if (key == myNumbers[mid])
                {
                    inputbox.Clear();
                    inputbox.Focus();
                    MessageBox.Show("FOUND: " + key, "Result",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
                else if (key < myNumbers[mid])
                {
                    maxNum = mid - 1;
                }
                else
                {
                    minNum = mid + 1;
                }
            }
            //Check if not found and display message
            for (int x = 0; x < myNumbers.Length; x++)
            {
                int mid = (minNum + maxNum) / 2;

                if (key != myNumbers[mid])
                {
                    MessageBox.Show("Not Found ", "Error",
                      MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                }
            }
        }

        private void editbox_TextChanged(object sender, EventArgs e)
        {

        }
        // User delete's array item then can replace that iteam with input
        private void editbutton_Click(object sender, EventArgs e)
        {
            // if the item is deleted (0) user can input new value
            if (!string.IsNullOrEmpty(inputbox.Text))
            {
                for (int x = 0; x < myNumbers.Length; x++)
                {
                    if (myNumbers[x] == 0)
                    {
                        myNumbers[x] = int.Parse(inputbox.Text);
                        break;
                    }
                }
            }
            else
            {
                MessageBox.Show("Delete then enter a integer", "Input Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            displayArray();
            // input not empty
            // find element = 0
            // add item to that cell
            // display
        }
        // initilise the array and display it to the Arraybox (listbox)
        // Ask if they would like to sort first since some features need the array sorted, this prevents potential errors.
        // if they click no on the tip message it wont sort it for them
        private void initilise_Click(object sender, EventArgs e)
        {
            initiliseArray();
            if (MessageBox.Show("Would You Like To Sort Before Using Any Features To Eliminate Potential ERRORS?", "TIP", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                for (int x = 0; x < myNumbers.Length - 1; x++)
                {
                    for (int y = 0; y < myNumbers.Length - 1; y++)
                    {
                        if (myNumbers[y] > myNumbers[y + 1])
                        {
                            int temp = myNumbers[y + 1];
                            myNumbers[y + 1] = myNumbers[y];
                            myNumbers[y] = temp;

                        }
                    }
                }
                displayArray();
            }
            else
            {
                displayArray();
            }          
           
            
        }
        public void TangoInc_Load(object sender, EventArgs e)
        {
            displayArray();
        }
        // user selects one array item then presses delete button to set it to 0 where they can add their own number or keep it at 0
        private void deletbutton_Click(object sender, EventArgs e)
        {
            // selected item set value '0'
            if (Arraybox.SelectedIndex != -1)
            {
                string currentItem = Arraybox.SelectedItem.ToString();
                int itemIndex = Arraybox.FindString(currentItem);

                myNumbers[itemIndex] = 0;
                inputbox.Clear();
                inputbox.Focus();
                displayArray();
            }
            else
            {
                MessageBox.Show("Please select and Item from the list", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            displayArray();
        }
        // input box is the interactive box to find and add numbers with.
        private void inputbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
                e.Handled = true;
        }
        // key down / clears / delete fearture
        private void inputbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                inputbox.Clear();
                inputbox.Focus();
            }
        }
        // Select items in the list box (Arraybox)
        private void Arraybox_Click(object sender, EventArgs e)
        {
            // Select number from array and assign that a value
            if (Arraybox.SelectedIndex != -1)
            {
                string currentItem = Arraybox.SelectedItem.ToString();
                int itemIndex = Arraybox.FindString(currentItem);
                inputbox.Text = myNumbers[itemIndex].ToString();
            }
            else
            {
                MessageBox.Show("Please select and Item from the list", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // bubble sort items check if next number is bigger < and if so psuh it down the list until all are sorted.
        private void bubblesort_Click(object sender, EventArgs e)
        {
            {
                // push larger numbers down list
                for (int x = 0; x < myNumbers.Length - 1; x++)
                {
                    for (int y = 0; y < myNumbers.Length - 1; y++)
                    {
                        if (myNumbers[y] > myNumbers[y + 1])
                        {
                            int temp = myNumbers[y + 1];
                            myNumbers[y + 1] = myNumbers[y];
                            myNumbers[y] = temp;

                        }
                    }
                }
                displayArray();
            }
        }

        private void Arraybox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // count the sum of numbers (i++) then / by 24 (the arrays size (.length)
        // make average display to 2 deciaml spaces
        private void average_Click(object sender, EventArgs e)
        {

            int i;            
            double sum = 0.00;
            double average = 0.00;

            for (i = 0; i < myNumbers.Length; i++)
            {
                sum += myNumbers[i];
            }

            average = (double)sum / myNumbers.Length;            
            textBox2.Text = (average).ToString("#.##");
            
        }
        // "The program must generate an error message if the text box is empty."
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            Text = textBox2.Text;
            if (textBox2.Text == "")

            {
                MessageBox.Show("Please make sort before selecting a function", "Error Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // after user sorts take the last number[23] (largest) from the first[0]
        // remember to remind the user to sort before using calculations
        // could auto sort when clicking Initilising to make it easier
        // array length is 0-23 != 1-24
        private void range_Click(object sender, EventArgs e)
        {
            double range = myNumbers[23] - myNumbers[0];
            textBox2.Text = range.ToString();
        }
        // user must sort
        // check if next number == and count how many times the number shows
        // display the number with the biggest count 
        
        private void mode_Click(object sender, EventArgs e)
        {
            int number = myNumbers[0];
            int mode = number;
            int count = 1;
            int countMode = 1;

            for (int i = 1; i < 24; i++)
            {
                if (myNumbers[i] == number)
                {
                    ++count;
                }
                else
                {
                    if (count > countMode)
                    {
                        countMode = count;
                        mode = number;
                    }
                    count = 1;
                    number = myNumbers[i];
                }
                textBox2.Text = mode.ToString();
            }
        }
        // mid-extreme = mid-range
        // bimdas** msut have the adition in brackets
        // smallest + largest / 2
        private void midextreme_Click(object sender, EventArgs e)
        {
           
            double midex = (myNumbers[0] + myNumbers[23]) / 2.0;
            textBox2.Text = midex.ToString();
        }
        // i++ until the user input == mynumbers[i]
        // Displays found + the number thats found
        // displays Input error if not
        private void sequentialsearch_Click(object sender, EventArgs e)
        {
            {
                int key = int.Parse(inputbox.Text);
                int i;
                if (!string.IsNullOrEmpty(inputbox.Text))
                {

                    for (i = 0; i < myNumbers.Length; i++)
                    {
                        if (myNumbers[i] == key)
                        {
                            inputbox.Clear();
                            inputbox.Focus();
                            MessageBox.Show("FOUND: " + key, "Sequential Search",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("NOT FOOUND: " + key, "Input Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    displayArray();
            }

        }
    }
}