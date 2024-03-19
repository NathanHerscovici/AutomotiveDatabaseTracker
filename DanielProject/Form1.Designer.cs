namespace DanielProject
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
            uxMainTabControl = new TabControl();
            uxTicketsTab = new TabPage();
            uxTicketPageTabControl = new TabControl();
            uxActiveTicketsPage = new TabPage();
            uxCompletedTicketsPage = new TabPage();
            uxCustomerInformationTab = new TabPage();
            uxMoneyTab = new TabPage();
            uxMoneyPageTabControl = new TabControl();
            uxMonthlyTabPage = new TabPage();
            uxYearlyBillTabPage = new TabPage();
            comboBox1 = new ComboBox();
            uxMainTabControl.SuspendLayout();
            uxTicketsTab.SuspendLayout();
            uxTicketPageTabControl.SuspendLayout();
            uxMoneyTab.SuspendLayout();
            uxMoneyPageTabControl.SuspendLayout();
            uxYearlyBillTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // uxMainTabControl
            // 
            uxMainTabControl.Controls.Add(uxTicketsTab);
            uxMainTabControl.Controls.Add(uxCustomerInformationTab);
            uxMainTabControl.Controls.Add(uxMoneyTab);
            uxMainTabControl.Dock = DockStyle.Fill;
            uxMainTabControl.Location = new Point(0, 0);
            uxMainTabControl.Name = "uxMainTabControl";
            uxMainTabControl.SelectedIndex = 0;
            uxMainTabControl.Size = new Size(800, 450);
            uxMainTabControl.TabIndex = 0;
            // 
            // uxTicketsTab
            // 
            uxTicketsTab.Controls.Add(uxTicketPageTabControl);
            uxTicketsTab.Location = new Point(4, 24);
            uxTicketsTab.Name = "uxTicketsTab";
            uxTicketsTab.Padding = new Padding(3);
            uxTicketsTab.Size = new Size(792, 422);
            uxTicketsTab.TabIndex = 0;
            uxTicketsTab.Text = "Tickets";
            uxTicketsTab.UseVisualStyleBackColor = true;
            // 
            // uxTicketPageTabControl
            // 
            uxTicketPageTabControl.Controls.Add(uxActiveTicketsPage);
            uxTicketPageTabControl.Controls.Add(uxCompletedTicketsPage);
            uxTicketPageTabControl.Dock = DockStyle.Fill;
            uxTicketPageTabControl.Location = new Point(3, 3);
            uxTicketPageTabControl.Name = "uxTicketPageTabControl";
            uxTicketPageTabControl.SelectedIndex = 0;
            uxTicketPageTabControl.Size = new Size(786, 416);
            uxTicketPageTabControl.TabIndex = 0;
            // 
            // uxActiveTicketsPage
            // 
            uxActiveTicketsPage.Location = new Point(4, 24);
            uxActiveTicketsPage.Name = "uxActiveTicketsPage";
            uxActiveTicketsPage.Padding = new Padding(3);
            uxActiveTicketsPage.Size = new Size(778, 388);
            uxActiveTicketsPage.TabIndex = 0;
            uxActiveTicketsPage.Text = "ActiveTickets";
            uxActiveTicketsPage.UseVisualStyleBackColor = true;
            // 
            // uxCompletedTicketsPage
            // 
            uxCompletedTicketsPage.Location = new Point(4, 24);
            uxCompletedTicketsPage.Name = "uxCompletedTicketsPage";
            uxCompletedTicketsPage.Padding = new Padding(3);
            uxCompletedTicketsPage.Size = new Size(778, 388);
            uxCompletedTicketsPage.TabIndex = 1;
            uxCompletedTicketsPage.Text = "Completed Tickets";
            uxCompletedTicketsPage.UseVisualStyleBackColor = true;
            // 
            // uxCustomerInformationTab
            // 
            uxCustomerInformationTab.Location = new Point(4, 24);
            uxCustomerInformationTab.Name = "uxCustomerInformationTab";
            uxCustomerInformationTab.Padding = new Padding(3);
            uxCustomerInformationTab.Size = new Size(792, 422);
            uxCustomerInformationTab.TabIndex = 1;
            uxCustomerInformationTab.Text = "Customer Information";
            uxCustomerInformationTab.UseVisualStyleBackColor = true;
            // 
            // uxMoneyTab
            // 
            uxMoneyTab.Controls.Add(uxMoneyPageTabControl);
            uxMoneyTab.Location = new Point(4, 24);
            uxMoneyTab.Name = "uxMoneyTab";
            uxMoneyTab.Padding = new Padding(3);
            uxMoneyTab.Size = new Size(792, 422);
            uxMoneyTab.TabIndex = 2;
            uxMoneyTab.Text = "Money";
            uxMoneyTab.UseVisualStyleBackColor = true;
            // 
            // uxMoneyPageTabControl
            // 
            uxMoneyPageTabControl.Controls.Add(uxMonthlyTabPage);
            uxMoneyPageTabControl.Controls.Add(uxYearlyBillTabPage);
            uxMoneyPageTabControl.Dock = DockStyle.Fill;
            uxMoneyPageTabControl.Location = new Point(3, 3);
            uxMoneyPageTabControl.Name = "uxMoneyPageTabControl";
            uxMoneyPageTabControl.SelectedIndex = 0;
            uxMoneyPageTabControl.Size = new Size(786, 416);
            uxMoneyPageTabControl.TabIndex = 0;
            // 
            // uxMonthlyTabPage
            // 
            uxMonthlyTabPage.Location = new Point(4, 24);
            uxMonthlyTabPage.Name = "uxMonthlyTabPage";
            uxMonthlyTabPage.Padding = new Padding(3);
            uxMonthlyTabPage.Size = new Size(778, 388);
            uxMonthlyTabPage.TabIndex = 0;
            uxMonthlyTabPage.Text = "Monthly Bill";
            uxMonthlyTabPage.UseVisualStyleBackColor = true;
            // 
            // uxYearlyBillTabPage
            // 
            uxYearlyBillTabPage.Controls.Add(comboBox1);
            uxYearlyBillTabPage.Location = new Point(4, 24);
            uxYearlyBillTabPage.Name = "uxYearlyBillTabPage";
            uxYearlyBillTabPage.Padding = new Padding(3);
            uxYearlyBillTabPage.Size = new Size(778, 388);
            uxYearlyBillTabPage.TabIndex = 1;
            uxYearlyBillTabPage.Text = "YearlyBill";
            uxYearlyBillTabPage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 6);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(uxMainTabControl);
            Name = "Form1";
            Text = "Form1";
            uxMainTabControl.ResumeLayout(false);
            uxTicketsTab.ResumeLayout(false);
            uxTicketPageTabControl.ResumeLayout(false);
            uxMoneyTab.ResumeLayout(false);
            uxMoneyPageTabControl.ResumeLayout(false);
            uxYearlyBillTabPage.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl uxMainTabControl;
        private TabPage uxTicketsTab;
        private TabPage uxCustomerInformationTab;
        private TabPage uxMoneyTab;
        private TabControl uxTicketPageTabControl;
        private TabPage uxActiveTicketsPage;
        private TabPage uxCompletedTicketsPage;
        private TabControl uxMoneyPageTabControl;
        private TabPage uxMonthlyTabPage;
        private TabPage uxYearlyBillTabPage;
        private ComboBox comboBox1;
    }
}