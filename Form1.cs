using System.ComponentModel.Design;

namespace Vendingmachine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbxCoinDrop.AllowDrop = true;
            pbxNoteDrop.AllowDrop = true;
        }

        private void FivePoundNote_MouseDown(object sender, MouseEventArgs e)
        {
            FivePoundNote.DoDragDrop("£5.00", DragDropEffects.Copy);
        }

        private void TenPoundNote_MouseDown(object sender, MouseEventArgs e)
        {
            TenPoundNote.DoDragDrop("£10.00", DragDropEffects.Copy);
        }

        private void OnePoundCoin_Click(object sender, EventArgs e)
        {
            OnePoundCoin.DoDragDrop("£1.00", DragDropEffects.Move);
            
        }

        private void TwoPoundCoin_MouseDown(object sender, MouseEventArgs e)
        {
            TwoPoundCoin.DoDragDrop("£2.00", DragDropEffects.Move);
        }

        private void TwentyPenceCoin_Click(object sender, EventArgs e)
        {

        }

        private void pbxNoteDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void pbxCoinDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect |= DragDropEffects.Move;
        }

        private void pbxCoinDrop_DragDrop(object sender, DragEventArgs e)
        {
            //get the value of the data that was dragged
            String value = e.Data.GetData(DataFormats.StringFormat) as String;

            //you might want tocase this an int, but for now, we just print it to check this works.
            MessageBox.Show(value);
            //subtract that from total
        }

        private void pbxNoteDrop_DragDrop(object sender, DragEventArgs e)
        {
            //get the value of the data that was dragged
            String value = e.Data.GetData(DataFormats.StringFormat) as String;

            //you might want tocase this an int, but for now, we just print it to check this works.
            MessageBox.Show(value);
            //subtract that from total

        }

        private void OnePoundCoin_MouseDown(object sender, MouseEventArgs e)
        {
            OnePoundCoin.DoDragDrop("1", DragDropEffects.Move);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = button1.Text;
            MessageBox.Show("Item name: Walkers R/S" + "Cash accepted" +
            "£2.00 - £1.35 = Change £0.65 ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = button2.Text;
            MessageBox.Show("Item name: MCCOY'S" + "Cash accepted" +
           "£2.00 - £1.35 = Change £0.65 ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = button3.Text;
            MessageBox.Show("Item name: Walkers C/O" + "Cash accepted" +
           "£1.00 - £1.00 = Change £0.00 ");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = button4.Text;
            MessageBox.Show("Item name: Rio" + "Cash accepted" +
           "£5.00 - £2.30 = Change £2.70 ");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = button5.Text;
            MessageBox.Show("Item name: Apple Juice" + "Cash accepted" +
           "£10.00 - £2.15 = Change £7.85 ");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = button6.Text;
            MessageBox.Show("Item name: Kisses" + "Cash accepted" +
           "£5.00 - £3.50 = Change £1.50 ");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = buttonX.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = Button0.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text = OK.Text;
            MessageBox.Show("Cash Accepted");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label1.Text = Cancel.Text;
            MessageBox.Show("Item Cancel");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label1.Text = Checkout.Text;
            MessageBox.Show("Item has been selected for Checkout");
            MessageBox.Show("Press item code for change");
            MessageBox.Show("Please Take Your Item, Thank You");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: MCCOY'S (2) " +
                "Item price: £1.35");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Walkers R/S (1)" +
                "Item price: £1.35");
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Walkers C/O (3)" +
                "Item price: £1.00");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Rio (4)" +
                "Item price: £2.30");
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Apple Juice (5)" +
                "Item price: £2.15");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Kisses (6)" +
                "Item price: £3.50");
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Walkers R/S (1)" +
                "Item price: £1.35");
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Walkers C/O (3)" +
                "Item price: £1.00");
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Rio (4)" +
                "Item price: £2.30");
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Apple Juice (5)" +
                "Item price: £2.15");
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Item name: Kisses (6)" +
                "Item price: £3.50");
        }
    }
}
