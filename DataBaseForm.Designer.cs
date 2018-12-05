using System.Windows.Forms;
namespace MTGDeckBuilder
{
  partial class DataBaseForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseForm));
      this.treeSets = new System.Windows.Forms.TreeView();
      this.panel1 = new System.Windows.Forms.Panel();
      this.comboSearch = new System.Windows.Forms.ComboBox();
      this.btnAddCard = new System.Windows.Forms.Button();
      this.pbxProxy = new System.Windows.Forms.PictureBox();
      this.lblCardName = new System.Windows.Forms.Label();
      this.txtSearchField = new System.Windows.Forms.TextBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.lblDataBaseTitle = new System.Windows.Forms.Label();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbxProxy)).BeginInit();
      this.SuspendLayout();
      // 
      // treeSets
      // 
      this.treeSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.treeSets.FullRowSelect = true;
      this.treeSets.Location = new System.Drawing.Point(3, 30);
      this.treeSets.Name = "treeSets";
      this.treeSets.Size = new System.Drawing.Size(257, 378);
      this.treeSets.TabIndex = 2;
      this.treeSets.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeSets_AfterSelect);
      this.treeSets.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeSets_MouseDoubleClick);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.comboSearch);
      this.panel1.Controls.Add(this.btnAddCard);
      this.panel1.Controls.Add(this.pbxProxy);
      this.panel1.Controls.Add(this.lblCardName);
      this.panel1.Controls.Add(this.txtSearchField);
      this.panel1.Controls.Add(this.treeSets);
      this.panel1.Location = new System.Drawing.Point(2, 29);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(543, 413);
      this.panel1.TabIndex = 3;
      // 
      // comboSearch
      // 
      this.comboSearch.FormattingEnabled = true;
      this.comboSearch.Items.AddRange(new object[] {
            ""});
      this.comboSearch.Location = new System.Drawing.Point(139, 5);
      this.comboSearch.Name = "comboSearch";
      this.comboSearch.Size = new System.Drawing.Size(121, 21);
      this.comboSearch.TabIndex = 8;
      this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
      // 
      // btnAddCard
      // 
      this.btnAddCard.FlatAppearance.BorderSize = 0;
      this.btnAddCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
      this.btnAddCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddCard.Location = new System.Drawing.Point(3, 3);
      this.btnAddCard.Name = "btnAddCard";
      this.btnAddCard.Size = new System.Drawing.Size(81, 23);
      this.btnAddCard.TabIndex = 6;
      this.btnAddCard.Text = "Añadir Carta";
      this.btnAddCard.UseVisualStyleBackColor = true;
      this.btnAddCard.Click += new System.EventHandler(this.btnAddCard_Click);
      // 
      // pbxProxy
      // 
      this.pbxProxy.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxProxy.InitialImage")));
      this.pbxProxy.Location = new System.Drawing.Point(266, 32);
      this.pbxProxy.Name = "pbxProxy";
      this.pbxProxy.Size = new System.Drawing.Size(271, 378);
      this.pbxProxy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.pbxProxy.TabIndex = 5;
      this.pbxProxy.TabStop = false;
      // 
      // lblCardName
      // 
      this.lblCardName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblCardName.AutoSize = true;
      this.lblCardName.Location = new System.Drawing.Point(-67, 8);
      this.lblCardName.Name = "lblCardName";
      this.lblCardName.Size = new System.Drawing.Size(43, 13);
      this.lblCardName.TabIndex = 4;
      this.lblCardName.Text = "Buscar:";
      // 
      // txtSearchField
      // 
      this.txtSearchField.Location = new System.Drawing.Point(266, 6);
      this.txtSearchField.Name = "txtSearchField";
      this.txtSearchField.Size = new System.Drawing.Size(271, 20);
      this.txtSearchField.TabIndex = 3;
      this.txtSearchField.TextChanged += new System.EventHandler(this.txtSearchField_TextChanged);
      // 
      // btnCancel
      // 
      this.btnCancel.FlatAppearance.BorderSize = 0;
      this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancel.Location = new System.Drawing.Point(516, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(24, 24);
      this.btnCancel.TabIndex = 7;
      this.btnCancel.Text = "X";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // lblDataBaseTitle
      // 
      this.lblDataBaseTitle.AutoSize = true;
      this.lblDataBaseTitle.Enabled = false;
      this.lblDataBaseTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDataBaseTitle.Location = new System.Drawing.Point(5, 4);
      this.lblDataBaseTitle.Name = "lblDataBaseTitle";
      this.lblDataBaseTitle.Size = new System.Drawing.Size(78, 20);
      this.lblDataBaseTitle.TabIndex = 0;
      this.lblDataBaseTitle.Text = "Coleccion";
      // 
      // DataBaseForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(548, 445);
      this.ControlBox = false;
      this.Controls.Add(this.lblDataBaseTitle);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DataBaseForm";
      this.ShowIcon = false;
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbxProxy)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.TreeView treeSets;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.PictureBox pbxProxy;
    private System.Windows.Forms.Label lblCardName;
    private System.Windows.Forms.TextBox txtSearchField;
    private System.Windows.Forms.Button btnAddCard;
    private System.Windows.Forms.Button btnCancel;
    private Label lblDataBaseTitle;
    private ComboBox comboSearch;
  }
}

