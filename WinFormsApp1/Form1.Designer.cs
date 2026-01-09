namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            nametxtbox = new TextBox();
            pwtxtbox = new TextBox();
            invitecodetxtbox = new TextBox();
            groupcodetxtbox = new TextBox();
            cpwtxtbox = new TextBox();
            FullNameLabel = new Label();
            BirthYearlabel = new Label();
            confirmplabel = new Label();
            passwordlabel = new Label();
            invitecodelabel = new Label();
            groupcodelabel = new Label();
            agelabel = new Label();
            acceptpwlabel = new Label();
            acceptcodelabel = new Label();
            agetxtbox = new TextBox();
            proccessbtn = new Button();
            SuspendLayout();
            // 
            // nametxtbox
            // 
            nametxtbox.Location = new Point(135, 54);
            nametxtbox.Name = "nametxtbox";
            nametxtbox.Size = new Size(222, 23);
            nametxtbox.TabIndex = 0;
            nametxtbox.TextChanged += textBox1_TextChanged;
            // 
            // pwtxtbox
            // 
            pwtxtbox.Location = new Point(135, 161);
            pwtxtbox.Name = "pwtxtbox";
            pwtxtbox.Size = new Size(222, 23);
            pwtxtbox.TabIndex = 3;
            pwtxtbox.TextChanged += pwtxtbox_TextChanged;
            // 
            // invitecodetxtbox
            // 
            invitecodetxtbox.Location = new Point(148, 327);
            invitecodetxtbox.Name = "invitecodetxtbox";
            invitecodetxtbox.Size = new Size(209, 23);
            invitecodetxtbox.TabIndex = 6;
            invitecodetxtbox.TextChanged += invitecodetxtbox_TextChanged;
            // 
            // groupcodetxtbox
            // 
            groupcodetxtbox.Location = new Point(148, 273);
            groupcodetxtbox.Name = "groupcodetxtbox";
            groupcodetxtbox.Size = new Size(209, 23);
            groupcodetxtbox.TabIndex = 5;
            groupcodetxtbox.TextChanged += groupcodetxtbox_TextChanged;
            // 
            // cpwtxtbox
            // 
            cpwtxtbox.Location = new Point(191, 222);
            cpwtxtbox.Name = "cpwtxtbox";
            cpwtxtbox.Size = new Size(166, 23);
            cpwtxtbox.TabIndex = 4;
            cpwtxtbox.TextChanged += cpwtxtbox_TextChanged;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.BackColor = SystemColors.GrayText;
            FullNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FullNameLabel.ForeColor = SystemColors.ControlLightLight;
            FullNameLabel.Location = new Point(48, 52);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(77, 21);
            FullNameLabel.TabIndex = 6;
            FullNameLabel.Text = "FullName";
            FullNameLabel.Click += FullNameLabel_Click;
            // 
            // BirthYearlabel
            // 
            BirthYearlabel.AutoSize = true;
            BirthYearlabel.BackColor = SystemColors.GrayText;
            BirthYearlabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BirthYearlabel.ForeColor = SystemColors.ControlLightLight;
            BirthYearlabel.Location = new Point(48, 104);
            BirthYearlabel.Name = "BirthYearlabel";
            BirthYearlabel.Size = new Size(77, 21);
            BirthYearlabel.TabIndex = 7;
            BirthYearlabel.Text = "Birth Year";
            BirthYearlabel.Click += BirthYearlabel_Click;
            // 
            // confirmplabel
            // 
            confirmplabel.AutoSize = true;
            confirmplabel.BackColor = SystemColors.GrayText;
            confirmplabel.Font = new Font("Segoe UI", 12F);
            confirmplabel.ForeColor = SystemColors.ControlLightLight;
            confirmplabel.Location = new Point(48, 220);
            confirmplabel.Name = "confirmplabel";
            confirmplabel.Size = new Size(137, 21);
            confirmplabel.TabIndex = 9;
            confirmplabel.Text = "Confirm Password";
            confirmplabel.Click += confirmplabel_Click;
            // 
            // passwordlabel
            // 
            passwordlabel.AutoSize = true;
            passwordlabel.BackColor = SystemColors.GrayText;
            passwordlabel.Font = new Font("Segoe UI", 12F);
            passwordlabel.ForeColor = SystemColors.ControlLightLight;
            passwordlabel.Location = new Point(48, 159);
            passwordlabel.Name = "passwordlabel";
            passwordlabel.Size = new Size(76, 21);
            passwordlabel.TabIndex = 8;
            passwordlabel.Text = "Password";
            passwordlabel.Click += passwordlabel_Click;
            // 
            // invitecodelabel
            // 
            invitecodelabel.AutoSize = true;
            invitecodelabel.BackColor = SystemColors.GrayText;
            invitecodelabel.Font = new Font("Segoe UI", 12F);
            invitecodelabel.ForeColor = SystemColors.ControlLightLight;
            invitecodelabel.Location = new Point(48, 327);
            invitecodelabel.Name = "invitecodelabel";
            invitecodelabel.Size = new Size(88, 21);
            invitecodelabel.TabIndex = 11;
            invitecodelabel.Text = "Invite Code";
            invitecodelabel.Click += invitecodelabel_Click;
            // 
            // groupcodelabel
            // 
            groupcodelabel.AutoSize = true;
            groupcodelabel.BackColor = SystemColors.GrayText;
            groupcodelabel.Font = new Font("Segoe UI", 12F);
            groupcodelabel.ForeColor = SystemColors.ControlLightLight;
            groupcodelabel.Location = new Point(48, 271);
            groupcodelabel.Name = "groupcodelabel";
            groupcodelabel.Size = new Size(94, 21);
            groupcodelabel.TabIndex = 10;
            groupcodelabel.Text = "Group Code";
            groupcodelabel.Click += groupcodelabel_Click;
            // 
            // agelabel
            // 
            agelabel.AutoSize = true;
            agelabel.BackColor = Color.Transparent;
            agelabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            agelabel.Location = new Point(136, 132);
            agelabel.Name = "agelabel";
            agelabel.Size = new Size(49, 17);
            agelabel.TabIndex = 13;
            agelabel.Text = "Age = ";
            agelabel.Click += agelabel_Click;
            // 
            // acceptpwlabel
            // 
            acceptpwlabel.AutoSize = true;
            acceptpwlabel.BackColor = Color.Transparent;
            acceptpwlabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            acceptpwlabel.Location = new Point(191, 248);
            acceptpwlabel.Name = "acceptpwlabel";
            acceptpwlabel.Size = new Size(73, 17);
            acceptpwlabel.TabIndex = 14;
            acceptpwlabel.Text = "ACCEPTED";
            acceptpwlabel.Click += acceptpwlabel_Click;
            // 
            // acceptcodelabel
            // 
            acceptcodelabel.AutoSize = true;
            acceptcodelabel.BackColor = Color.Transparent;
            acceptcodelabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            acceptcodelabel.Location = new Point(148, 353);
            acceptcodelabel.Name = "acceptcodelabel";
            acceptcodelabel.Size = new Size(73, 17);
            acceptcodelabel.TabIndex = 15;
            acceptcodelabel.Text = "ACCEPTED";
            acceptcodelabel.Click += acceptcodelabel_Click;
            // 
            // agetxtbox
            // 
            agetxtbox.Location = new Point(135, 106);
            agetxtbox.Name = "agetxtbox";
            agetxtbox.Size = new Size(50, 23);
            agetxtbox.TabIndex = 2;
            agetxtbox.TextChanged += agetxtbox_TextChanged_1;
            // 
            // proccessbtn
            // 
            proccessbtn.BackColor = SystemColors.GradientActiveCaption;
            proccessbtn.FlatAppearance.BorderColor = Color.Black;
            proccessbtn.FlatStyle = FlatStyle.Flat;
            proccessbtn.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            proccessbtn.Location = new Point(135, 435);
            proccessbtn.Name = "proccessbtn";
            proccessbtn.Size = new Size(184, 64);
            proccessbtn.TabIndex = 17;
            proccessbtn.Text = "Process";
            proccessbtn.UseVisualStyleBackColor = false;
            proccessbtn.Click += proccessbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            BackgroundImage = Properties.Resources.registration_login_keyboard_man;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(404, 572);
            Controls.Add(proccessbtn);
            Controls.Add(agetxtbox);
            Controls.Add(acceptcodelabel);
            Controls.Add(acceptpwlabel);
            Controls.Add(agelabel);
            Controls.Add(invitecodelabel);
            Controls.Add(groupcodelabel);
            Controls.Add(confirmplabel);
            Controls.Add(passwordlabel);
            Controls.Add(BirthYearlabel);
            Controls.Add(FullNameLabel);
            Controls.Add(invitecodetxtbox);
            Controls.Add(groupcodetxtbox);
            Controls.Add(cpwtxtbox);
            Controls.Add(pwtxtbox);
            Controls.Add(nametxtbox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        // =================== FIXED EVENT METHODS ===================
        private void pwtxtbox_TextChanged(object sender, EventArgs e) { }
        private void invitecodetxtbox_TextChanged(object sender, EventArgs e) { }
        private void groupcodetxtbox_TextChanged(object sender, EventArgs e) { }
        private void cpwtxtbox_TextChanged(object sender, EventArgs e) { }
        private void agetxtbox_TextChanged_1(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void FullNameLabel_Click(object sender, EventArgs e) { }
        private void BirthYearlabel_Click(object sender, EventArgs e) { }
        private void confirmplabel_Click(object sender, EventArgs e) { }
        private void passwordlabel_Click(object sender, EventArgs e) { }
        private void invitecodelabel_Click(object sender, EventArgs e) { }
        private void groupcodelabel_Click(object sender, EventArgs e) { }
        private void agelabel_Click(object sender, EventArgs e) { }
        private void acceptpwlabel_Click(object sender, EventArgs e) { }
        private void acceptcodelabel_Click(object sender, EventArgs e) { }

        #endregion

        private TextBox nametxtbox;
        private TextBox pwtxtbox;
        private TextBox invitecodetxtbox;
        private TextBox groupcodetxtbox;
        private TextBox cpwtxtbox;
        private Label FullNameLabel;
        private Label BirthYearlabel;
        private Label confirmplabel;
        private Label passwordlabel;
        private Label invitecodelabel;
        private Label groupcodelabel;
        private Label agelabel;
        private Label acceptpwlabel;
        private Label acceptcodelabel;
        private TextBox agetxtbox;
        private Button proccessbtn;
    }
}
