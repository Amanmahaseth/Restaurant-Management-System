namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void FriesCb_CheckedChanged(object sender, EventArgs e)
        {
            if(FriesCb.Checked == true)
            {
                FriesTb.Enabled = true;
            }
            if(FriesCb.Checked == false)
            {
                FriesTb.Enabled = false;
                FriesTb.Text = "0";
            }
        }

        private void BurgerCb_CheckedChanged(object sender, EventArgs e)
        {
            if (BurgerCb.Checked == true)
            {
                BurgerTb.Enabled = true;
            }
            if (BurgerCb.Checked == false)
            {
                BurgerTb.Enabled = false;
                BurgerTb.Text = "0";
            }
        }

        private void SandwichCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SandwichCb.Checked == true)
            {
                SandwichTb.Enabled = true;
            }
            if (SandwichCb.Checked == false)
            {
                SandwichTb.Enabled = false;
                SandwichTb.Text = "0";
            }
        }

        private void ChickenCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChickenCb.Checked == true)
            {
                ChickenTb.Enabled = true;
            }
            if (ChickenCb.Checked == false)
            {
                ChickenTb.Enabled = false;
                ChickenTb.Text = "0";
            }
        }

        private void MomoCb_CheckedChanged(object sender, EventArgs e)
        {
            if (MomoCb.Checked == true)
            {
                MomoTb.Enabled = true;
            }
            if (MomoCb.Checked == false)
            {
                MomoTb.Enabled = false;
                MomoTb.Text = "0";
            }
        }

        private void SausageCb_CheckedChanged(object sender, EventArgs e)
        {
            if (SausageCb.Checked == true)
            {
                SausageTb.Enabled = true;
            }
            if (SausageCb.Checked == false)
            {
                SausageTb.Enabled = false;
                SausageTb.Text = "0";
            }
        }

        private void TeaCb_CheckedChanged(object sender, EventArgs e)
        {
            if (TeaCb.Checked == true)
            {
                TeaTb.Enabled = true;
            }
            if (TeaCb.Checked == false)
            {
                TeaTb.Enabled = false;
                TeaTb.Text = "0";
            }
        }

        private void CoffeeCb_CheckedChanged(object sender, EventArgs e)
        {
            if (CoffeeCb.Checked == true)
            {
                CoffeeTb.Enabled = true;
            }
            if (CoffeeCb.Checked == false)
            {
                CoffeeTb.Enabled = false;
                CoffeeTb.Text = "0";
            }
        }

        private void WaterCb_CheckedChanged(object sender, EventArgs e)
        {
            if (WaterCb.Checked == true)
            {
                WaterTb.Enabled = true;
            }
            if (WaterCb.Checked == false)
            {
                WaterTb.Enabled = false;
                WaterTb.Text = "0";
            }
        }

        private void PepsiCb_CheckedChanged(object sender, EventArgs e)
        {
            if (PepsiCb.Checked == true)
            {
                PepsiTb.Enabled = true;
            }
            if (PepsiCb.Checked == false)
            {
                PepsiTb.Enabled = false;
                PepsiTb.Text = "0";
            }
        }

        private void PancakesCb_CheckedChanged(object sender, EventArgs e)
        {

            if (PancakesCb.Checked == true)
            {
                PancakesTb.Enabled = true;
            }
            if (PancakesCb.Checked == false)
            {
                PancakesTb.Enabled = false;
                PancakesTb.Text = "0";
            }
        }

        private void ChocolateCb_CheckedChanged(object sender, EventArgs e)
        {
            if (ChocolateCb.Checked == true)
            {
                ChocolateTb.Enabled = true;
            }
            if (ChocolateCb.Checked == false)
            {
                ChocolateTb.Enabled = false;
                ChocolateTb.Text = "0";
            }
        }

        private void closelbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }
        // Declaration of unit price of different meal and drinks
        double friesup = 50, burgerup = 120, sandwichup = 150, chickenup = 180, momoup = 120, sausageup = 50;

        private void button1_Click(object sender, EventArgs e)
        {
            FriesCb.Checked = false;
            BurgerCb.Checked = false;
            SandwichCb.Checked = false;
            ChickenCb.Checked = false;
            MomoCb.Checked = false;
            SausageCb.Checked = false;
            TeaCb.Checked = false;
            CoffeeCb.Checked = false;
            WaterCb.Checked = false;
            PepsiCb.Checked = false;
            PancakesCb.Checked = false;
            ChocolateCb.Checked = false;

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ReceiptTb.Text + "Subtotal" + Subtotallbl.Text + "Tax: " + taxlbl.Text + "Total" + totallbl.Text, new Font("Century Gothic", 12, FontStyle.Regular), Brushes.Blue, new Point(130));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();

            }
        }

        double teaup = 25, coffeeup = 120, waterup = 40, pepsiup = 180, pancakeup = 250, chocolateup = 150;
        // Declaration of variable for total price
        double friestp, burgertp, sandwichtp, chickentp, momotp, sausagetp, teatp, coffeetp, watertp, pepsitp, pancaketp, chocolatetp;
        double Subtotal = 0, tax, total;
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            friestp= friesup * Convert.ToDouble(FriesTb.Text);
            burgertp = burgerup * Convert.ToDouble(BurgerTb.Text);
            sandwichtp = sandwichup * Convert.ToDouble(SandwichTb.Text);
            chickentp = chickenup * Convert.ToDouble(ChickenTb.Text);
            momotp = momoup * Convert.ToDouble(MomoTb.Text);
            sausagetp = sausageup * Convert.ToDouble(SausageTb.Text);
            //Lets do same for drinks
            teatp = teaup * Convert.ToDouble(TeaTb.Text);
            coffeetp = coffeeup * Convert.ToDouble(CoffeeTb.Text);
            watertp=waterup* Convert.ToDouble(WaterTb.Text);
            pepsitp= pepsiup*Convert.ToDouble(PepsiTb.Text);
            pancaketp = pancakeup * Convert.ToDouble(PancakesTb.Text);
            chocolatetp=chocolateup*Convert.ToDouble(ChocolateTb.Text);

            ReceiptTb.Clear();
            Subtotal = 0;
            ReceiptTb.AppendText(Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t AAYUSH RESTAURANT" + Environment.NewLine);
            ReceiptTb.AppendText("\t\t\t **************************" + Environment.NewLine);
            if (FriesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tFries:\t"+friestp+"Rs"+Environment.NewLine);
                Subtotal = Subtotal + friestp;
                Subtotallbl.Text = "" +Subtotal;

            }
            if (BurgerCb.Checked == true)
            {
                ReceiptTb.AppendText("\tBurger:\t" + burgertp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + burgertp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (SandwichCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSandwich:" + sandwichtp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sandwichtp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (ChickenCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChicken:\t" + chickentp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal +chickentp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (MomoCb.Checked == true)
            {
                ReceiptTb.AppendText("\tMomo:\t" + momotp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + momotp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (SausageCb.Checked == true)
            {
                ReceiptTb.AppendText("\tSausage:\t" + sausagetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + sausagetp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (TeaCb.Checked == true)
            {
                ReceiptTb.AppendText("\tTea:\t" + teatp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + teatp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (CoffeeCb.Checked == true)
            {
                ReceiptTb.AppendText("\tCoffee:\t" + coffeetp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + coffeetp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (PepsiCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPepsi:\t" + pepsitp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + pepsitp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (PancakesCb.Checked == true)
            {
                ReceiptTb.AppendText("\tPancakes:\t" + pancaketp + "Rs" + Environment.NewLine);
                Subtotal = Subtotal + pancaketp;
                Subtotallbl.Text = "" + Subtotal;

            }
            if (ChocolateCb.Checked == true)
            {
                ReceiptTb.AppendText("\tChocolate:\t" + chocolatetp + "Rs." + Environment.NewLine);
                Subtotal = Subtotal + chocolatetp;
                Subtotallbl.Text = "" + Subtotal;
               
            }
            tax = Subtotal * 0.16;
            total = Subtotal + tax;
            taxlbl.Text = "Rs" + tax;
            totallbl.Text = "Rs" + total;

        }

        private void ReceiptTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
} 
