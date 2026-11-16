namespace FruitManagementProject2
{
    public partial class Form1 : Form
    {
        // List
        private List<Fruit> fruits = new List<Fruit>();

        public Form1()
        {
            InitializeComponent();
        }

        //
        // Get Fruit Info
        //
        private bool getData(Fruit fruit)
        {
            double price;
            int quantity;

            //convert string input to double (price)
            if (!double.TryParse(Pricetxt.Text, out price) || price < 0)
            {
                MessageBox.Show("Please enter a valid price", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // convert (quantity)
            if (!int.TryParse(Quantitytxt.Text, out quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Check repeated case
            foreach (Fruit item in fruits)
            {
                if (item.Name.ToLower() == fruit.Name.ToLower() && item.Shape.ToLower() == fruit.Shape.ToLower()
                    && item.Color.ToLower() == fruit.Color.ToLower() && item.SeedType == fruit.SeedType)
                {
                    MessageBox.Show("Reapeated item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            // store
            fruit.Price = price;
            fruit.Quantity = quantity;
            return true;
        }

        //
        // ADD BUTTON
        //
        private void Addbtn_Click(object sender, EventArgs e)
        {
            // name
            string fruitName = Nametxt.Text.Trim();
            string fruitColor = Colortxt.Text.Trim();
            string fruitShape = Shapetxt.Text.Trim();

            if (string.IsNullOrEmpty(fruitName) || string.IsNullOrEmpty(fruitColor) || string.IsNullOrEmpty(fruitShape))
            {
                MessageBox.Show("Invalid. Please enter all infomation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Determine seed type
            string seed_type = "";

            if (NoSeedrdo.Checked)
            {
                seed_type = "No Seed";
            }
            else if (SmallSeedrdo.Checked)
            {
                seed_type = "Small Seed";
            }
            else if (LargeSeedrdo.Checked)
            {
                seed_type = "Large Seed";
            }
            if (seed_type == "")
            {
                MessageBox.Show("Please select seed type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Create a data object
            Fruit fruit_data = new Fruit(fruitName, fruitColor, fruitShape, seed_type, 0, 0);
            // Check input
            if (getData(fruit_data) == false)
            {
                return;
            }
            else
            {
                // Add to list
                fruits.Add(fruit_data);
                Fruitlst.Items.Add(fruit_data.Name + ", " + fruit_data.Color + ", " +
                    fruit_data.Shape + ", " + "Quantity: " + fruit_data.Quantity + " Price: " + fruit_data.Price.ToString("f2"));
                MessageBox.Show("Successfully added!", "Announce", MessageBoxButtons.OK);

                // Sort
                Fruitlst.Sorted = true;

                // Clear form
                NoSeedrdo.Checked = false;
                SmallSeedrdo.Checked = false;
                LargeSeedrdo.Checked = false;

                Nametxt.Clear();
                Shapetxt.Clear();
                Colortxt.Clear();
                Pricetxt.Clear();
                Quantitytxt.Clear();
            }
        }
        //
        // CLEAR BUTTON
        //
        private void Clearbtn_Click(object sender, EventArgs e)
        {
            NoSeedrdo.Checked = false;
            SmallSeedrdo.Checked = false;
            LargeSeedrdo.Checked = false;

            Nametxt.Clear();
            Shapetxt.Clear();
            Colortxt.Clear();
            Pricetxt.Clear();
            Quantitytxt.Clear();
            TotalPricetxt.Clear();
            TotalQuantitytxt.Clear();
        }

        //
        // CALCULATE TOTAL PRICE 
        //
        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            double total = 0;
            int quantiy = 0;

            foreach (Fruit item in fruits)
            {
                total += item.Price * item.Quantity;
                quantiy += item.Quantity;
            }
            if (total == 0 && quantiy == 0)
            {
                MessageBox.Show("Invalid. Please enter all infomation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                TotalPricetxt.Text = total.ToString("f2");
                TotalQuantitytxt.Text = quantiy.ToString();
            }
        }

        //
        // DELETE BUTTON
        //
        private void Deletebtn_Click(object sender, EventArgs e)
        {
            if (Fruitlst.SelectedIndex != -1)
            {
                fruits.RemoveAt(Fruitlst.SelectedIndex);
                Fruitlst.Items.RemoveAt(Fruitlst.SelectedIndex);
                MessageBox.Show("Successfully deleted!", "Announce", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Please select item from the list", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
