namespace ASM_2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            gb = new GroupBox();
            btnHCal = new Button();
            txtnumberp = new TextBox();
            label9 = new Label();
            btnCal = new Button();
            txtDescription = new TextBox();
            txtTotal = new TextBox();
            txtWaterUsed = new TextBox();
            btnPrint = new Button();
            linkLabel1 = new LinkLabel();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            btnAdd = new Button();
            txtCurrentmonth = new TextBox();
            txtLastmonth = new TextBox();
            label6 = new Label();
            cbTypes = new ComboBox();
            txtAddress = new TextBox();
            txtname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            listView = new ListView();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gb
            // 
            gb.Controls.Add(btnHCal);
            gb.Controls.Add(txtnumberp);
            gb.Controls.Add(label9);
            gb.Controls.Add(btnCal);
            gb.Controls.Add(txtDescription);
            gb.Controls.Add(txtTotal);
            gb.Controls.Add(txtWaterUsed);
            gb.Controls.Add(btnPrint);
            gb.Controls.Add(linkLabel1);
            gb.Controls.Add(label11);
            gb.Controls.Add(label10);
            gb.Controls.Add(label8);
            gb.Controls.Add(txtPhone);
            gb.Controls.Add(label7);
            gb.Controls.Add(btnEdit);
            gb.Controls.Add(btnDelete);
            gb.Controls.Add(btnClear);
            gb.Controls.Add(btnAdd);
            gb.Controls.Add(txtCurrentmonth);
            gb.Controls.Add(txtLastmonth);
            gb.Controls.Add(label6);
            gb.Controls.Add(cbTypes);
            gb.Controls.Add(txtAddress);
            gb.Controls.Add(txtname);
            gb.Controls.Add(label5);
            gb.Controls.Add(label4);
            gb.Controls.Add(label3);
            gb.Controls.Add(label2);
            gb.Controls.Add(label1);
            gb.Location = new Point(12, 12);
            gb.Name = "gb";
            gb.Size = new Size(1105, 353);
            gb.TabIndex = 3;
            gb.TabStop = false;
            gb.Text = "User's Information";
            // 
            // btnHCal
            // 
            btnHCal.Location = new Point(791, 236);
            btnHCal.Name = "btnHCal";
            btnHCal.Size = new Size(156, 23);
            btnHCal.TabIndex = 31;
            btnHCal.Text = "How to calculate";
            btnHCal.UseVisualStyleBackColor = true;
            btnHCal.Click += btnHCal_Click;
            // 
            // txtnumberp
            // 
            txtnumberp.Location = new Point(129, 217);
            txtnumberp.Name = "txtnumberp";
            txtnumberp.Size = new Size(206, 23);
            txtnumberp.TabIndex = 30;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 225);
            label9.Name = "label9";
            label9.Size = new Size(107, 15);
            label9.TabIndex = 29;
            label9.Text = "Number of people:";
            // 
            // btnCal
            // 
            btnCal.Location = new Point(641, 310);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(105, 23);
            btnCal.TabIndex = 28;
            btnCal.Text = "Calculate the bill";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(706, 59);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(304, 171);
            txtDescription.TabIndex = 27;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(414, 237);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(170, 23);
            txtTotal.TabIndex = 26;
            // 
            // txtWaterUsed
            // 
            txtWaterUsed.Location = new Point(414, 178);
            txtWaterUsed.Name = "txtWaterUsed";
            txtWaterUsed.ReadOnly = true;
            txtWaterUsed.Size = new Size(170, 23);
            txtWaterUsed.TabIndex = 25;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(781, 310);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(75, 23);
            btnPrint.TabIndex = 23;
            btnPrint.Text = "Print bill";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(810, 80);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(0, 15);
            linkLabel1.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(414, 212);
            label11.Name = "label11";
            label11.Size = new Size(137, 15);
            label11.TabIndex = 21;
            label11.Text = "Total Bill (Price with Tax):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(414, 152);
            label10.Name = "label10";
            label10.Size = new Size(121, 15);
            label10.TabIndex = 20;
            label10.Text = "Amout of water used:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(832, 41);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 18;
            label8.Text = "Description";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(116, 125);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(219, 23);
            txtPhone.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 125);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 16;
            label7.Text = "Phone number:";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(299, 310);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 23);
            btnEdit.TabIndex = 15;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(534, 310);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(414, 310);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 13;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(185, 310);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtCurrentmonth
            // 
            txtCurrentmonth.Location = new Point(510, 107);
            txtCurrentmonth.Name = "txtCurrentmonth";
            txtCurrentmonth.Size = new Size(123, 23);
            txtCurrentmonth.TabIndex = 11;
            // 
            // txtLastmonth
            // 
            txtLastmonth.Location = new Point(510, 69);
            txtLastmonth.Name = "txtLastmonth";
            txtLastmonth.Size = new Size(123, 23);
            txtLastmonth.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(414, 110);
            label6.Name = "label6";
            label6.Size = new Size(89, 15);
            label6.TabIndex = 9;
            label6.Text = "Current month:";
            // 
            // cbTypes
            // 
            cbTypes.FormattingEnabled = true;
            cbTypes.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            cbTypes.Location = new Point(116, 174);
            cbTypes.Name = "cbTypes";
            cbTypes.Size = new Size(219, 23);
            cbTypes.TabIndex = 8;
            cbTypes.SelectedIndexChanged += cbTypes_SelectedIndexChanged;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(116, 76);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(219, 23);
            txtAddress.TabIndex = 7;
            // 
            // txtname
            // 
            txtname.Location = new Point(116, 28);
            txtname.Name = "txtname";
            txtname.Size = new Size(219, 23);
            txtname.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(414, 72);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Last month:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(414, 32);
            label4.Name = "label4";
            label4.Size = new Size(114, 15);
            label4.TabIndex = 3;
            label4.Text = "Record Water's used";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 76);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 2;
            label3.Text = "Address: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 174);
            label2.Name = "label2";
            label2.Size = new Size(94, 15);
            label2.TabIndex = 1;
            label2.Text = "Customer Types:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 31);
            label1.Name = "label1";
            label1.Size = new Size(97, 15);
            label1.TabIndex = 0;
            label1.Text = "Customer Name:";
            // 
            // listView
            // 
            listView.Location = new Point(12, 371);
            listView.Name = "listView";
            listView.Size = new Size(1105, 264);
            listView.TabIndex = 4;
            listView.UseCompatibleStateImageBehavior = false;
            listView.View = View.Details;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged_1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Business_Elegant_Presentation_Template;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1129, 647);
            Controls.Add(listView);
            Controls.Add(gb);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Calculate water bill";
            Load += Form2_Load;
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private GroupBox gb;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private Button btnAdd;
        private TextBox txtCurrentmonth;
        private TextBox txtLastmonth;
        private Label label6;
        private ComboBox cbTypes;
        private TextBox txtAddress;
        private TextBox txtname;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private Label label7;
        private Label label8;
        private LinkLabel linkLabel1;
        private Label label11;
        private Label label10;
        private ListView listView;
        private Button btnPrint;
        private TextBox txtDescription;
        private TextBox txtTotal;
        private TextBox txtWaterUsed;
        private Button btnCal;
        private Label label9;
        private TextBox txtnumberp;
        private Button btnHCal;
    }
}