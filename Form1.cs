using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace POS
{
    public partial class MainApp : Form
    {
        public MainApp()
        {
            InitializeComponent();
        }

        private int count = 0;
        private decimal bill = 0;
        private decimal change = 0;

        private void AddFood(object sender, EventArgs e)
        {
            description.Text = ((Button)sender).Text;
            ((Button)sender).Enabled = false;
            count++;
            if (count > 1)
            {
                for (int i = 1; i <= 10; i++)
                {
                    string butNum = "food" + i;
                    if (this.Controls[butNum] == ((Button)sender))
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls[butNum].Enabled = true;
                    }
                }
            }
        }

        private void AddFoodToList_Click(object sender, EventArgs e)
        {
            try
            {
                string food = description.Text;
                int k = food.IndexOf('@');
                int x = food.Length;
                string foodPriceString = food.Substring(k + 1, (x - k) - 1);
                int quantityOfTheItem = int.Parse(quantity.Text);
                decimal price = decimal.Parse(foodPriceString);
                decimal extendedPrice = price * quantityOfTheItem;
                foodList.Items.Add(quantityOfTheItem + " x " + food + " = " + extendedPrice);
                if(foodList.Items.Count > 0)
                {
                    decimal totalBill = decimal.Parse(amount.Text);
                    totalBill += extendedPrice;
                    bill = totalBill;
                    amount.Text = totalBill.ToString();
                    Payment.Enabled = true;
                }
            }
            catch
            {         
                MessageBox.Show("Enter something in, Comrade", "Error 1991", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Payment_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please enter the payment and press Enter to set up the payment of the Sale, Comrade.", "Stalin is Best Leader", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Payment.Enabled = false;
            amount.Enabled = true;
            AddFoodToList.Enabled = false;
            foodList.Enabled = false;
            quantity.Enabled = false;
            description.Text = string.Empty;
            OperationLabel.Text = "Payment:";
            quantity.Text = (1).ToString();
            for(int i = 1; i <= 10; i++)
            {
                string butNum = "food" + i;
                Controls[butNum].Enabled = false;
            }
        }

        private void EnterPayment(object sender, KeyPressEventArgs e)
        {
            try
            {
                if(e.KeyChar == 13)
                {
                    decimal payment = decimal.Parse(amount.Text);
                    if (bill > payment)
                    {
                        MessageBox.Show("The bill is larger than the payment, tell the officer to send that person to the gulags!", "For Mother Russia! URA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        change = payment - bill;
                        MessageBox.Show("The Change has been set, Comrade", "Our Glorious Leader is Kim Jong Un.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Chang.Enabled = true;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Enter a proper value, Vadim", "Lenin is our father.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            Chang.Enabled = false;
            amount.Enabled = false;
            amount.Text = change.ToString();
            OperationLabel.Text = "Change:";
            NextSale.Enabled = true;
        }

        private void NextSale_Click(object sender, EventArgs e)
        {
            foodList.Items.Clear();
            NextSale.Enabled = false;
            amount.Text = "0.00";
            for(int i = 1; i <= 10; i++)
            {
                string butNum = "food" + i;
                this.Controls[butNum].Enabled = true;
            }
            AddFoodToList.Enabled = true;
            quantity.Enabled = true;
            foodList.Enabled = true;
            OperationLabel.Text = "Sale:";
        }
        private void RemoveItemFromList(object sender, EventArgs e)
        {
            if (foodList.SelectedIndex != -1)
            {
                int i = foodList.SelectedIndex;
                string item = foodList.Items[i].ToString();
                int k = item.IndexOf('=');
                int l = item.Length;
                string itemPriceString = item.Substring(k + 2, (l - k) - 2);
                decimal itemPrice = decimal.Parse(itemPriceString);
                decimal totalBill = decimal.Parse(amount.Text);
                totalBill -= itemPrice;
                amount.Text = totalBill.ToString();
                bill = totalBill;
                foodList.Items.RemoveAt(i);
                if (foodList.Items.Count == 0)
                {
                    Payment.Enabled = false;
                }
            }
        }

        private void MainApp_Load(object sender, EventArgs e)
        {
            //MusicPlayer musicPlayer = new MusicPlayer();
            //SongChange songChange = new SongChange();
            //musicPlayer.MusicEnded += songChange.OnMusicEnded;
            //musicPlayer.PlayMusic();
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;
            this.Location = new Point(0, 0);
            this.Size = new Size(width, height);

            SoundPlayer player = new SoundPlayer
            {
                SoundLocation = "EpicSovietPlaylist.wav"
            };
            player.PlayLooping();
        }

        private void ExitForm(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
