namespace FruitManagementProject2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FruitInfolbl = new Label();
            Namelbl = new Label();
            Nametxt = new TextBox();
            Colorlbl = new Label();
            Colortxt = new TextBox();
            Shapelbl = new Label();
            Shapetxt = new TextBox();
            Seedlbl = new Label();
            NoSeedrdo = new RadioButton();
            SmallSeedrdo = new RadioButton();
            LargeSeedrdo = new RadioButton();
            Pricelbl = new Label();
            Pricetxt = new TextBox();
            Quantitylbl = new Label();
            Quantitytxt = new TextBox();
            Addbtn = new Button();
            Calculatebtn = new Button();
            Clearbtn = new Button();
            Deletebtn = new Button();
            Fruitlst = new ListBox();
            Totalgrp = new GroupBox();
            Overalllbl = new Label();
            TotalQuantitytxt = new TextBox();
            TotalQuantitylbl = new Label();
            TotalPricetxt = new TextBox();
            TotalPricelbl = new Label();
            Infogrp = new GroupBox();
            FruitListgrp = new GroupBox();
            Listlbl = new Label();
            Totalgrp.SuspendLayout();
            Infogrp.SuspendLayout();
            FruitListgrp.SuspendLayout();
            SuspendLayout();
            // 
            // FruitInfolbl
            // 
            FruitInfolbl.AutoSize = true;
            FruitInfolbl.Font = new Font("Lucida Bright", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FruitInfolbl.ForeColor = Color.DarkSlateGray;
            FruitInfolbl.Location = new Point(33, 24);
            FruitInfolbl.Name = "FruitInfolbl";
            FruitInfolbl.Size = new Size(642, 45);
            FruitInfolbl.TabIndex = 0;
            FruitInfolbl.Text = "Fruit Information Management";
            // 
            // Namelbl
            // 
            Namelbl.AutoSize = true;
            Namelbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            Namelbl.ForeColor = Color.DarkSlateGray;
            Namelbl.Location = new Point(12, 43);
            Namelbl.Name = "Namelbl";
            Namelbl.Size = new Size(86, 26);
            Namelbl.TabIndex = 1;
            Namelbl.Text = "Name:";
            // 
            // Nametxt
            // 
            Nametxt.Location = new Point(98, 42);
            Nametxt.Name = "Nametxt";
            Nametxt.Size = new Size(158, 27);
            Nametxt.TabIndex = 2;
            // 
            // Colorlbl
            // 
            Colorlbl.AutoSize = true;
            Colorlbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            Colorlbl.ForeColor = Color.DarkSlateGray;
            Colorlbl.Location = new Point(362, 40);
            Colorlbl.Name = "Colorlbl";
            Colorlbl.Size = new Size(82, 26);
            Colorlbl.TabIndex = 3;
            Colorlbl.Text = "Color:";
            // 
            // Colortxt
            // 
            Colortxt.Location = new Point(468, 42);
            Colortxt.Name = "Colortxt";
            Colortxt.Size = new Size(162, 27);
            Colortxt.TabIndex = 4;
            // 
            // Shapelbl
            // 
            Shapelbl.AutoSize = true;
            Shapelbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            Shapelbl.ForeColor = Color.DarkSlateGray;
            Shapelbl.Location = new Point(12, 137);
            Shapelbl.Name = "Shapelbl";
            Shapelbl.Size = new Size(86, 26);
            Shapelbl.TabIndex = 5;
            Shapelbl.Text = "Shape:";
            // 
            // Shapetxt
            // 
            Shapetxt.Location = new Point(100, 136);
            Shapetxt.Name = "Shapetxt";
            Shapetxt.Size = new Size(156, 27);
            Shapetxt.TabIndex = 6;
            // 
            // Seedlbl
            // 
            Seedlbl.AutoSize = true;
            Seedlbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            Seedlbl.ForeColor = Color.DarkSlateGray;
            Seedlbl.Location = new Point(12, 219);
            Seedlbl.Name = "Seedlbl";
            Seedlbl.Size = new Size(138, 26);
            Seedlbl.TabIndex = 7;
            Seedlbl.Text = "Seed Type:";
            // 
            // NoSeedrdo
            // 
            NoSeedrdo.AutoSize = true;
            NoSeedrdo.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NoSeedrdo.Location = new Point(177, 219);
            NoSeedrdo.Name = "NoSeedrdo";
            NoSeedrdo.Size = new Size(115, 27);
            NoSeedrdo.TabIndex = 8;
            NoSeedrdo.TabStop = true;
            NoSeedrdo.Text = "No Seed";
            NoSeedrdo.UseVisualStyleBackColor = true;
            // 
            // SmallSeedrdo
            // 
            SmallSeedrdo.AutoSize = true;
            SmallSeedrdo.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SmallSeedrdo.Location = new Point(177, 252);
            SmallSeedrdo.Name = "SmallSeedrdo";
            SmallSeedrdo.Size = new Size(142, 27);
            SmallSeedrdo.TabIndex = 9;
            SmallSeedrdo.TabStop = true;
            SmallSeedrdo.Text = "Small Seed";
            SmallSeedrdo.UseVisualStyleBackColor = true;
            // 
            // LargeSeedrdo
            // 
            LargeSeedrdo.AutoSize = true;
            LargeSeedrdo.Font = new Font("Lucida Bright", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LargeSeedrdo.Location = new Point(177, 285);
            LargeSeedrdo.Name = "LargeSeedrdo";
            LargeSeedrdo.Size = new Size(143, 27);
            LargeSeedrdo.TabIndex = 10;
            LargeSeedrdo.TabStop = true;
            LargeSeedrdo.Text = "Large Seed";
            LargeSeedrdo.UseVisualStyleBackColor = true;
            // 
            // Pricelbl
            // 
            Pricelbl.AutoSize = true;
            Pricelbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            Pricelbl.ForeColor = Color.DarkSlateGray;
            Pricelbl.Location = new Point(362, 137);
            Pricelbl.Name = "Pricelbl";
            Pricelbl.Size = new Size(105, 26);
            Pricelbl.TabIndex = 11;
            Pricelbl.Text = "Price($):";
            // 
            // Pricetxt
            // 
            Pricetxt.Location = new Point(468, 136);
            Pricetxt.Name = "Pricetxt";
            Pricetxt.Size = new Size(162, 27);
            Pricetxt.TabIndex = 12;
            // 
            // Quantitylbl
            // 
            Quantitylbl.AutoSize = true;
            Quantitylbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold);
            Quantitylbl.ForeColor = Color.DarkSlateGray;
            Quantitylbl.Location = new Point(12, 354);
            Quantitylbl.Name = "Quantitylbl";
            Quantitylbl.Size = new Size(119, 26);
            Quantitylbl.TabIndex = 14;
            Quantitylbl.Text = "Quantity:";
            // 
            // Quantitytxt
            // 
            Quantitytxt.Location = new Point(148, 354);
            Quantitytxt.Name = "Quantitytxt";
            Quantitytxt.Size = new Size(144, 27);
            Quantitytxt.TabIndex = 15;
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.DarkSeaGreen;
            Addbtn.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            Addbtn.ForeColor = Color.DarkSlateGray;
            Addbtn.Location = new Point(35, 521);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(321, 44);
            Addbtn.TabIndex = 16;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // Calculatebtn
            // 
            Calculatebtn.BackColor = Color.PaleTurquoise;
            Calculatebtn.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            Calculatebtn.ForeColor = Color.MidnightBlue;
            Calculatebtn.Location = new Point(362, 521);
            Calculatebtn.Name = "Calculatebtn";
            Calculatebtn.Size = new Size(320, 44);
            Calculatebtn.TabIndex = 17;
            Calculatebtn.Text = "Calulate Total";
            Calculatebtn.UseVisualStyleBackColor = false;
            Calculatebtn.Click += Calculatebtn_Click;
            // 
            // Clearbtn
            // 
            Clearbtn.BackColor = Color.BurlyWood;
            Clearbtn.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            Clearbtn.ForeColor = Color.DarkSlateGray;
            Clearbtn.Location = new Point(35, 571);
            Clearbtn.Name = "Clearbtn";
            Clearbtn.Size = new Size(321, 44);
            Clearbtn.TabIndex = 18;
            Clearbtn.Text = "Clear";
            Clearbtn.UseVisualStyleBackColor = false;
            Clearbtn.Click += Clearbtn_Click;
            // 
            // Deletebtn
            // 
            Deletebtn.BackColor = Color.Pink;
            Deletebtn.Font = new Font("Lucida Bright", 10.8F, FontStyle.Bold);
            Deletebtn.ForeColor = Color.Crimson;
            Deletebtn.Location = new Point(362, 571);
            Deletebtn.Name = "Deletebtn";
            Deletebtn.Size = new Size(320, 44);
            Deletebtn.TabIndex = 19;
            Deletebtn.Text = "Delete";
            Deletebtn.UseVisualStyleBackColor = false;
            Deletebtn.Click += Deletebtn_Click;
            // 
            // Fruitlst
            // 
            Fruitlst.BackColor = Color.LavenderBlush;
            Fruitlst.Font = new Font("Lucida Bright", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Fruitlst.ForeColor = Color.DodgerBlue;
            Fruitlst.FormattingEnabled = true;
            Fruitlst.Location = new Point(13, 87);
            Fruitlst.Name = "Fruitlst";
            Fruitlst.Size = new Size(380, 310);
            Fruitlst.TabIndex = 20;
            // 
            // Totalgrp
            // 
            Totalgrp.BackColor = Color.NavajoWhite;
            Totalgrp.Controls.Add(Overalllbl);
            Totalgrp.Controls.Add(TotalQuantitytxt);
            Totalgrp.Controls.Add(TotalQuantitylbl);
            Totalgrp.Controls.Add(TotalPricetxt);
            Totalgrp.Controls.Add(TotalPricelbl);
            Totalgrp.Location = new Point(719, 436);
            Totalgrp.Name = "Totalgrp";
            Totalgrp.Size = new Size(408, 181);
            Totalgrp.TabIndex = 21;
            Totalgrp.TabStop = false;
            // 
            // Overalllbl
            // 
            Overalllbl.AutoSize = true;
            Overalllbl.Font = new Font("Lucida Bright", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Overalllbl.ForeColor = Color.DarkGoldenrod;
            Overalllbl.Location = new Point(151, 23);
            Overalllbl.Name = "Overalllbl";
            Overalllbl.Size = new Size(142, 39);
            Overalllbl.TabIndex = 11;
            Overalllbl.Text = "Overall";
            // 
            // TotalQuantitytxt
            // 
            TotalQuantitytxt.Location = new Point(212, 131);
            TotalQuantitytxt.Name = "TotalQuantitytxt";
            TotalQuantitytxt.Size = new Size(165, 27);
            TotalQuantitytxt.TabIndex = 15;
            // 
            // TotalQuantitylbl
            // 
            TotalQuantitylbl.AutoSize = true;
            TotalQuantitylbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalQuantitylbl.ForeColor = Color.DodgerBlue;
            TotalQuantitylbl.Location = new Point(28, 133);
            TotalQuantitylbl.Name = "TotalQuantitylbl";
            TotalQuantitylbl.Size = new Size(151, 26);
            TotalQuantitylbl.TabIndex = 14;
            TotalQuantitylbl.Text = "Total Items:";
            // 
            // TotalPricetxt
            // 
            TotalPricetxt.Location = new Point(212, 85);
            TotalPricetxt.Name = "TotalPricetxt";
            TotalPricetxt.Size = new Size(165, 27);
            TotalPricetxt.TabIndex = 13;
            // 
            // TotalPricelbl
            // 
            TotalPricelbl.AutoSize = true;
            TotalPricelbl.Font = new Font("Lucida Bright", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPricelbl.ForeColor = Color.DodgerBlue;
            TotalPricelbl.Location = new Point(29, 83);
            TotalPricelbl.Name = "TotalPricelbl";
            TotalPricelbl.Size = new Size(144, 26);
            TotalPricelbl.TabIndex = 8;
            TotalPricelbl.Text = "Total Price:";
            // 
            // Infogrp
            // 
            Infogrp.BackColor = Color.MediumTurquoise;
            Infogrp.Controls.Add(LargeSeedrdo);
            Infogrp.Controls.Add(SmallSeedrdo);
            Infogrp.Controls.Add(NoSeedrdo);
            Infogrp.Controls.Add(Seedlbl);
            Infogrp.Controls.Add(Nametxt);
            Infogrp.Controls.Add(Namelbl);
            Infogrp.Controls.Add(Colorlbl);
            Infogrp.Controls.Add(Quantitytxt);
            Infogrp.Controls.Add(Colortxt);
            Infogrp.Controls.Add(Quantitylbl);
            Infogrp.Controls.Add(Shapelbl);
            Infogrp.Controls.Add(Shapetxt);
            Infogrp.Controls.Add(Pricelbl);
            Infogrp.Controls.Add(Pricetxt);
            Infogrp.Location = new Point(33, 82);
            Infogrp.Name = "Infogrp";
            Infogrp.Size = new Size(649, 416);
            Infogrp.TabIndex = 22;
            Infogrp.TabStop = false;
            // 
            // FruitListgrp
            // 
            FruitListgrp.BackColor = Color.LightPink;
            FruitListgrp.Controls.Add(Listlbl);
            FruitListgrp.Controls.Add(Fruitlst);
            FruitListgrp.Location = new Point(719, 12);
            FruitListgrp.Name = "FruitListgrp";
            FruitListgrp.Size = new Size(408, 413);
            FruitListgrp.TabIndex = 23;
            FruitListgrp.TabStop = false;
            // 
            // Listlbl
            // 
            Listlbl.AutoSize = true;
            Listlbl.Font = new Font("Lucida Bright", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Listlbl.ForeColor = Color.Crimson;
            Listlbl.Location = new Point(121, 23);
            Listlbl.Name = "Listlbl";
            Listlbl.Size = new Size(172, 39);
            Listlbl.TabIndex = 21;
            Listlbl.Text = "Fruit List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            ClientSize = new Size(1139, 641);
            Controls.Add(FruitListgrp);
            Controls.Add(Infogrp);
            Controls.Add(Totalgrp);
            Controls.Add(Deletebtn);
            Controls.Add(Clearbtn);
            Controls.Add(Calculatebtn);
            Controls.Add(Addbtn);
            Controls.Add(FruitInfolbl);
            Name = "Form1";
            Text = "Fruit Management System";
            Totalgrp.ResumeLayout(false);
            Totalgrp.PerformLayout();
            Infogrp.ResumeLayout(false);
            Infogrp.PerformLayout();
            FruitListgrp.ResumeLayout(false);
            FruitListgrp.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FruitInfolbl;
        private Label Namelbl;
        private TextBox Nametxt;
        private Label Colorlbl;
        private TextBox Colortxt;
        private Label Shapelbl;
        private TextBox Shapetxt;
        private Label Seedlbl;
        private RadioButton NoSeedrdo;
        private RadioButton SmallSeedrdo;
        private RadioButton LargeSeedrdo;
        private Label Pricelbl;
        private TextBox Pricetxt;
        private Label Quantitylbl;
        private TextBox Quantitytxt;
        private Button Addbtn;
        private Button Calculatebtn;
        private Button Clearbtn;
        private Button Deletebtn;
        private ListBox Fruitlst;
        private GroupBox Totalgrp;
        private Label TotalQuantitylbl;
        private TextBox TotalPricetxt;
        private Label TotalPricelbl;
        private Label Overalllbl;
        private TextBox TotalQuantitytxt;
        private GroupBox Infogrp;
        private GroupBox FruitListgrp;
        private Label Listlbl;
    }
}
