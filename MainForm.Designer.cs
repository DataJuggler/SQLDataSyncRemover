namespace SQLDataSyncRemover
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.RemoveDataSyncButton = new System.Windows.Forms.Button();
            this.SQLFileControl = new DataJuggler.Win.Controls.LabelTextBoxBrowserControl();
            this.SuspendLayout();
            // 
            // RemoveDataSyncButton
            // 
            this.RemoveDataSyncButton.Location = new System.Drawing.Point(285, 190);
            this.RemoveDataSyncButton.Name = "RemoveDataSyncButton";
            this.RemoveDataSyncButton.Size = new System.Drawing.Size(278, 34);
            this.RemoveDataSyncButton.TabIndex = 0;
            this.RemoveDataSyncButton.Text = "Remove Data Sync";
            this.RemoveDataSyncButton.UseVisualStyleBackColor = true;
            this.RemoveDataSyncButton.Click += new System.EventHandler(this.RemoveDataSyncButton_Click);
            // 
            // SQLFileControl
            // 
            this.SQLFileControl.BackColor = System.Drawing.Color.Transparent;
            this.SQLFileControl.BrowseType = DataJuggler.Win.Controls.Enumerations.BrowseTypeEnum.File;
            this.SQLFileControl.ButtonImage = ((System.Drawing.Image)(resources.GetObject("SQLFileControl.ButtonImage")));
            this.SQLFileControl.ButtonWidth = 48;
            this.SQLFileControl.DisabledLabelColor = System.Drawing.Color.LightGray;
            this.SQLFileControl.Editable = false;
            this.SQLFileControl.EnabledLabelColor = System.Drawing.Color.LemonChiffon;
            this.SQLFileControl.Filter = null;
            this.SQLFileControl.Font = new System.Drawing.Font("Verdana", 12F);
            this.SQLFileControl.HideBrowseButton = false;
            this.SQLFileControl.LabelBottomMargin = 0;
            this.SQLFileControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.SQLFileControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.SQLFileControl.LabelText = "SQL File:";
            this.SQLFileControl.LabelTopMargin = 0;
            this.SQLFileControl.LabelWidth = 120;
            this.SQLFileControl.Location = new System.Drawing.Point(163, 136);
            this.SQLFileControl.Name = "SQLFileControl";
            this.SQLFileControl.OnTextChangedListener = null;
            this.SQLFileControl.OpenCallback = null;
            this.SQLFileControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SQLFileControl.SelectedPath = null;
            this.SQLFileControl.Size = new System.Drawing.Size(400, 32);
            this.SQLFileControl.StartPath = null;
            this.SQLFileControl.TabIndex = 1;
            this.SQLFileControl.TextBoxBottomMargin = 0;
            this.SQLFileControl.TextBoxDisabledColor = System.Drawing.Color.Empty;
            this.SQLFileControl.TextBoxEditableColor = System.Drawing.Color.Empty;
            this.SQLFileControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F);
            this.SQLFileControl.TextBoxTopMargin = 0;
            this.SQLFileControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::SQLDataSyncRemover.Properties.Resources.Eerie;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SQLFileControl);
            this.Controls.Add(this.RemoveDataSyncButton);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL DataSync Remover";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button RemoveDataSyncButton;
        private DataJuggler.Win.Controls.LabelTextBoxBrowserControl SQLFileControl;
    }
}

