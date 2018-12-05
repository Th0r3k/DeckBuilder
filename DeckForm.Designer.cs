namespace MTGDeckBuilder.Deck
{
  partial class DeckForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeckForm));
      this.menu = new System.Windows.Forms.MenuStrip();
      this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.libreriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cargarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.theGathererToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panelDeck = new System.Windows.Forms.Panel();
      this.listCards = new System.Windows.Forms.ListBox();
      this.btnAddNewCard = new System.Windows.Forms.Button();
      this.panel3 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.cardBox = new System.Windows.Forms.GroupBox();
      this.panel10 = new System.Windows.Forms.Panel();
      this.txtToughtness = new System.Windows.Forms.TextBox();
      this.txtPower = new System.Windows.Forms.TextBox();
      this.lblToughtness = new System.Windows.Forms.Label();
      this.lblPower = new System.Windows.Forms.Label();
      this.panel14 = new System.Windows.Forms.Panel();
      this.txtArtist = new System.Windows.Forms.TextBox();
      this.lblArtist = new System.Windows.Forms.Label();
      this.panel13 = new System.Windows.Forms.Panel();
      this.txtNumber = new System.Windows.Forms.TextBox();
      this.lblNumber = new System.Windows.Forms.Label();
      this.panel12 = new System.Windows.Forms.Panel();
      this.txtRarity = new System.Windows.Forms.TextBox();
      this.lblRarity = new System.Windows.Forms.Label();
      this.panel11 = new System.Windows.Forms.Panel();
      this.txtCollection = new System.Windows.Forms.TextBox();
      this.lblSet = new System.Windows.Forms.Label();
      this.panel9 = new System.Windows.Forms.Panel();
      this.txtText = new System.Windows.Forms.TextBox();
      this.lblText = new System.Windows.Forms.Label();
      this.panel8 = new System.Windows.Forms.Panel();
      this.txtType = new System.Windows.Forms.TextBox();
      this.lblType = new System.Windows.Forms.Label();
      this.panel5 = new System.Windows.Forms.Panel();
      this.panel6 = new System.Windows.Forms.Panel();
      this.txtCRC = new System.Windows.Forms.TextBox();
      this.txtManaCost = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.lblMana = new System.Windows.Forms.Label();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.lblManaCost = new System.Windows.Forms.Label();
      this.panel4 = new System.Windows.Forms.Panel();
      this.txtOriginal = new System.Windows.Forms.TextBox();
      this.lblOriginalName = new System.Windows.Forms.Label();
      this.panelName = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.txtName = new System.Windows.Forms.TextBox();
      this.lblCardName = new System.Windows.Forms.Label();
      this.proxyImage = new System.Windows.Forms.PictureBox();
      this.lblDeckTitle = new System.Windows.Forms.Label();
      this.menu.SuspendLayout();
      this.panel1.SuspendLayout();
      this.panelDeck.SuspendLayout();
      this.panel3.SuspendLayout();
      this.panel2.SuspendLayout();
      this.cardBox.SuspendLayout();
      this.panel10.SuspendLayout();
      this.panel14.SuspendLayout();
      this.panel13.SuspendLayout();
      this.panel12.SuspendLayout();
      this.panel11.SuspendLayout();
      this.panel9.SuspendLayout();
      this.panel8.SuspendLayout();
      this.panel5.SuspendLayout();
      this.panel6.SuspendLayout();
      this.panel4.SuspendLayout();
      this.panelName.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.proxyImage)).BeginInit();
      this.SuspendLayout();
      // 
      // menu
      // 
      this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.menu.BackColor = System.Drawing.SystemColors.ControlDark;
      this.menu.Dock = System.Windows.Forms.DockStyle.None;
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.libreriaToolStripMenuItem});
      this.menu.Location = new System.Drawing.Point(-4, 2);
      this.menu.Name = "menu";
      this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.menu.Size = new System.Drawing.Size(126, 24);
      this.menu.TabIndex = 0;
      this.menu.Text = "menu";
      // 
      // archivoToolStripMenuItem
      // 
      this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.salirToolStripMenuItem});
      this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
      this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.archivoToolStripMenuItem.Text = "Archivo";
      // 
      // abrirToolStripMenuItem
      // 
      this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
      this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.abrirToolStripMenuItem.Text = "Abrir";
      this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
      // 
      // guardarToolStripMenuItem
      // 
      this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
      this.guardarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.guardarToolStripMenuItem.Text = "Guardar";
      this.guardarToolStripMenuItem.Click += new System.EventHandler(this.guardarToolStripMenuItem_Click);
      // 
      // guardarComoToolStripMenuItem
      // 
      this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
      this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.guardarComoToolStripMenuItem.Text = "Guardar Como";
      this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
      // 
      // imprimirToolStripMenuItem
      // 
      this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
      this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.imprimirToolStripMenuItem.Text = "Imprimir";
      this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
      // 
      // salirToolStripMenuItem
      // 
      this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
      this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.salirToolStripMenuItem.Text = "Salir";
      this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
      // 
      // libreriaToolStripMenuItem
      // 
      this.libreriaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarToolStripMenuItem,
            this.importarToolStripMenuItem});
      this.libreriaToolStripMenuItem.Name = "libreriaToolStripMenuItem";
      this.libreriaToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
      this.libreriaToolStripMenuItem.Text = "Libreria";
      // 
      // cargarToolStripMenuItem
      // 
      this.cargarToolStripMenuItem.Name = "cargarToolStripMenuItem";
      this.cargarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
      this.cargarToolStripMenuItem.Text = "Cargar";
      this.cargarToolStripMenuItem.Click += new System.EventHandler(this.cargarToolStripMenuItem_Click);
      // 
      // importarToolStripMenuItem
      // 
      this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.theGathererToolStripMenuItem});
      this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
      this.importarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
      this.importarToolStripMenuItem.Text = "Importar";
      // 
      // theGathererToolStripMenuItem
      // 
      this.theGathererToolStripMenuItem.Name = "theGathererToolStripMenuItem";
      this.theGathererToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
      this.theGathererToolStripMenuItem.Text = "The Gatherer";
      this.theGathererToolStripMenuItem.Click += new System.EventHandler(this.theGathererToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.panelDeck);
      this.panel1.Controls.Add(this.panel3);
      this.panel1.Controls.Add(this.menu);
      this.panel1.Location = new System.Drawing.Point(0, 27);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1351, 693);
      this.panel1.TabIndex = 1;
      // 
      // panelDeck
      // 
      this.panelDeck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.panelDeck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelDeck.Controls.Add(this.listCards);
      this.panelDeck.Controls.Add(this.btnAddNewCard);
      this.panelDeck.Location = new System.Drawing.Point(3, 31);
      this.panelDeck.Name = "panelDeck";
      this.panelDeck.Size = new System.Drawing.Size(230, 657);
      this.panelDeck.TabIndex = 0;
      // 
      // listCards
      // 
      this.listCards.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.listCards.BackColor = System.Drawing.Color.LightGray;
      this.listCards.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.listCards.CausesValidation = false;
      this.listCards.FormattingEnabled = true;
      this.listCards.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.listCards.Location = new System.Drawing.Point(3, 29);
      this.listCards.Name = "listCards";
      this.listCards.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.listCards.Size = new System.Drawing.Size(222, 613);
      this.listCards.Sorted = true;
      this.listCards.TabIndex = 2;
      this.listCards.SelectedIndexChanged += new System.EventHandler(this.listCards_SelectedIndexChanged);
      // 
      // btnAddNewCard
      // 
      this.btnAddNewCard.BackColor = System.Drawing.SystemColors.ControlDark;
      this.btnAddNewCard.FlatAppearance.BorderSize = 0;
      this.btnAddNewCard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
      this.btnAddNewCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAddNewCard.Location = new System.Drawing.Point(4, 3);
      this.btnAddNewCard.Name = "btnAddNewCard";
      this.btnAddNewCard.Size = new System.Drawing.Size(75, 23);
      this.btnAddNewCard.TabIndex = 1;
      this.btnAddNewCard.Text = "Añadir";
      this.btnAddNewCard.UseVisualStyleBackColor = false;
      this.btnAddNewCard.Click += new System.EventHandler(this.btnAddNewCard_Click);
      // 
      // panel3
      // 
      this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel3.Controls.Add(this.panel2);
      this.panel3.Controls.Add(this.proxyImage);
      this.panel3.Location = new System.Drawing.Point(-2, 27);
      this.panel3.Name = "panel3";
      this.panel3.Size = new System.Drawing.Size(1370, 665);
      this.panel3.TabIndex = 2;
      // 
      // panel2
      // 
      this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
      this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel2.Controls.Add(this.cardBox);
      this.panel2.Location = new System.Drawing.Point(237, 3);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(566, 657);
      this.panel2.TabIndex = 3;
      // 
      // cardBox
      // 
      this.cardBox.Controls.Add(this.panel10);
      this.cardBox.Controls.Add(this.panel14);
      this.cardBox.Controls.Add(this.panel13);
      this.cardBox.Controls.Add(this.panel12);
      this.cardBox.Controls.Add(this.panel11);
      this.cardBox.Controls.Add(this.panel9);
      this.cardBox.Controls.Add(this.panel8);
      this.cardBox.Controls.Add(this.panel5);
      this.cardBox.Controls.Add(this.panel4);
      this.cardBox.Controls.Add(this.panelName);
      this.cardBox.Location = new System.Drawing.Point(3, 3);
      this.cardBox.Name = "cardBox";
      this.cardBox.Size = new System.Drawing.Size(559, 649);
      this.cardBox.TabIndex = 0;
      this.cardBox.TabStop = false;
      // 
      // panel10
      // 
      this.panel10.BackColor = System.Drawing.Color.DarkGray;
      this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel10.Controls.Add(this.txtToughtness);
      this.panel10.Controls.Add(this.txtPower);
      this.panel10.Controls.Add(this.lblToughtness);
      this.panel10.Controls.Add(this.lblPower);
      this.panel10.Location = new System.Drawing.Point(6, 296);
      this.panel10.Name = "panel10";
      this.panel10.Size = new System.Drawing.Size(547, 28);
      this.panel10.TabIndex = 2;
      // 
      // txtToughtness
      // 
      this.txtToughtness.Enabled = false;
      this.txtToughtness.Location = new System.Drawing.Point(346, 3);
      this.txtToughtness.Name = "txtToughtness";
      this.txtToughtness.Size = new System.Drawing.Size(196, 20);
      this.txtToughtness.TabIndex = 1;
      // 
      // txtPower
      // 
      this.txtPower.Enabled = false;
      this.txtPower.Location = new System.Drawing.Point(74, 3);
      this.txtPower.Name = "txtPower";
      this.txtPower.Size = new System.Drawing.Size(196, 20);
      this.txtPower.TabIndex = 1;
      // 
      // lblToughtness
      // 
      this.lblToughtness.AutoSize = true;
      this.lblToughtness.Location = new System.Drawing.Point(276, 7);
      this.lblToughtness.Name = "lblToughtness";
      this.lblToughtness.Size = new System.Drawing.Size(65, 13);
      this.lblToughtness.TabIndex = 0;
      this.lblToughtness.Text = "Resistencia:";
      // 
      // lblPower
      // 
      this.lblPower.AutoSize = true;
      this.lblPower.Location = new System.Drawing.Point(4, 7);
      this.lblPower.Name = "lblPower";
      this.lblPower.Size = new System.Drawing.Size(42, 13);
      this.lblPower.TabIndex = 0;
      this.lblPower.Text = "Fuerza:";
      // 
      // panel14
      // 
      this.panel14.BackColor = System.Drawing.Color.DarkGray;
      this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel14.Controls.Add(this.txtArtist);
      this.panel14.Controls.Add(this.lblArtist);
      this.panel14.Location = new System.Drawing.Point(6, 432);
      this.panel14.Name = "panel14";
      this.panel14.Size = new System.Drawing.Size(547, 28);
      this.panel14.TabIndex = 2;
      // 
      // txtArtist
      // 
      this.txtArtist.Enabled = false;
      this.txtArtist.Location = new System.Drawing.Point(74, 3);
      this.txtArtist.Name = "txtArtist";
      this.txtArtist.Size = new System.Drawing.Size(468, 20);
      this.txtArtist.TabIndex = 1;
      // 
      // lblArtist
      // 
      this.lblArtist.AutoSize = true;
      this.lblArtist.Location = new System.Drawing.Point(4, 7);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new System.Drawing.Size(39, 13);
      this.lblArtist.TabIndex = 0;
      this.lblArtist.Text = "Artista:";
      // 
      // panel13
      // 
      this.panel13.BackColor = System.Drawing.Color.DarkGray;
      this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel13.Controls.Add(this.txtNumber);
      this.panel13.Controls.Add(this.lblNumber);
      this.panel13.Location = new System.Drawing.Point(6, 398);
      this.panel13.Name = "panel13";
      this.panel13.Size = new System.Drawing.Size(547, 28);
      this.panel13.TabIndex = 2;
      // 
      // txtNumber
      // 
      this.txtNumber.Enabled = false;
      this.txtNumber.Location = new System.Drawing.Point(74, 3);
      this.txtNumber.Name = "txtNumber";
      this.txtNumber.Size = new System.Drawing.Size(468, 20);
      this.txtNumber.TabIndex = 1;
      // 
      // lblNumber
      // 
      this.lblNumber.AutoSize = true;
      this.lblNumber.Location = new System.Drawing.Point(4, 7);
      this.lblNumber.Name = "lblNumber";
      this.lblNumber.Size = new System.Drawing.Size(47, 13);
      this.lblNumber.TabIndex = 0;
      this.lblNumber.Text = "Numero:";
      // 
      // panel12
      // 
      this.panel12.BackColor = System.Drawing.Color.DarkGray;
      this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel12.Controls.Add(this.txtRarity);
      this.panel12.Controls.Add(this.lblRarity);
      this.panel12.Location = new System.Drawing.Point(6, 364);
      this.panel12.Name = "panel12";
      this.panel12.Size = new System.Drawing.Size(547, 28);
      this.panel12.TabIndex = 2;
      // 
      // txtRarity
      // 
      this.txtRarity.Enabled = false;
      this.txtRarity.Location = new System.Drawing.Point(74, 3);
      this.txtRarity.Name = "txtRarity";
      this.txtRarity.Size = new System.Drawing.Size(468, 20);
      this.txtRarity.TabIndex = 1;
      // 
      // lblRarity
      // 
      this.lblRarity.AutoSize = true;
      this.lblRarity.Location = new System.Drawing.Point(4, 7);
      this.lblRarity.Name = "lblRarity";
      this.lblRarity.Size = new System.Drawing.Size(44, 13);
      this.lblRarity.TabIndex = 0;
      this.lblRarity.Text = "Rareza:";
      // 
      // panel11
      // 
      this.panel11.BackColor = System.Drawing.Color.DarkGray;
      this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel11.Controls.Add(this.txtCollection);
      this.panel11.Controls.Add(this.lblSet);
      this.panel11.Location = new System.Drawing.Point(6, 330);
      this.panel11.Name = "panel11";
      this.panel11.Size = new System.Drawing.Size(547, 28);
      this.panel11.TabIndex = 2;
      // 
      // txtCollection
      // 
      this.txtCollection.Enabled = false;
      this.txtCollection.Location = new System.Drawing.Point(74, 3);
      this.txtCollection.Name = "txtCollection";
      this.txtCollection.Size = new System.Drawing.Size(468, 20);
      this.txtCollection.TabIndex = 1;
      // 
      // lblSet
      // 
      this.lblSet.AutoSize = true;
      this.lblSet.Location = new System.Drawing.Point(4, 7);
      this.lblSet.Name = "lblSet";
      this.lblSet.Size = new System.Drawing.Size(59, 13);
      this.lblSet.TabIndex = 0;
      this.lblSet.Text = "Colleccion:";
      // 
      // panel9
      // 
      this.panel9.BackColor = System.Drawing.Color.DarkGray;
      this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel9.Controls.Add(this.txtText);
      this.panel9.Controls.Add(this.lblText);
      this.panel9.Location = new System.Drawing.Point(6, 155);
      this.panel9.Name = "panel9";
      this.panel9.Size = new System.Drawing.Size(547, 135);
      this.panel9.TabIndex = 2;
      // 
      // txtText
      // 
      this.txtText.AcceptsReturn = true;
      this.txtText.Enabled = false;
      this.txtText.Location = new System.Drawing.Point(74, 3);
      this.txtText.Multiline = true;
      this.txtText.Name = "txtText";
      this.txtText.Size = new System.Drawing.Size(468, 127);
      this.txtText.TabIndex = 1;
      // 
      // lblText
      // 
      this.lblText.AutoSize = true;
      this.lblText.Location = new System.Drawing.Point(4, 7);
      this.lblText.Name = "lblText";
      this.lblText.Size = new System.Drawing.Size(37, 13);
      this.lblText.TabIndex = 0;
      this.lblText.Text = "Texto:";
      // 
      // panel8
      // 
      this.panel8.BackColor = System.Drawing.Color.DarkGray;
      this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel8.Controls.Add(this.txtType);
      this.panel8.Controls.Add(this.lblType);
      this.panel8.Location = new System.Drawing.Point(6, 121);
      this.panel8.Name = "panel8";
      this.panel8.Size = new System.Drawing.Size(547, 28);
      this.panel8.TabIndex = 2;
      // 
      // txtType
      // 
      this.txtType.Enabled = false;
      this.txtType.Location = new System.Drawing.Point(74, 3);
      this.txtType.Name = "txtType";
      this.txtType.Size = new System.Drawing.Size(468, 20);
      this.txtType.TabIndex = 1;
      // 
      // lblType
      // 
      this.lblType.AutoSize = true;
      this.lblType.Location = new System.Drawing.Point(4, 7);
      this.lblType.Name = "lblType";
      this.lblType.Size = new System.Drawing.Size(31, 13);
      this.lblType.TabIndex = 0;
      this.lblType.Text = "Tipo:";
      // 
      // panel5
      // 
      this.panel5.BackColor = System.Drawing.Color.DarkGray;
      this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel5.Controls.Add(this.panel6);
      this.panel5.Controls.Add(this.textBox3);
      this.panel5.Controls.Add(this.lblManaCost);
      this.panel5.Location = new System.Drawing.Point(6, 87);
      this.panel5.Name = "panel5";
      this.panel5.Size = new System.Drawing.Size(547, 28);
      this.panel5.TabIndex = 0;
      // 
      // panel6
      // 
      this.panel6.BackColor = System.Drawing.Color.DarkGray;
      this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel6.Controls.Add(this.txtCRC);
      this.panel6.Controls.Add(this.txtManaCost);
      this.panel6.Controls.Add(this.label1);
      this.panel6.Controls.Add(this.lblMana);
      this.panel6.Location = new System.Drawing.Point(-1, -1);
      this.panel6.Name = "panel6";
      this.panel6.Size = new System.Drawing.Size(547, 28);
      this.panel6.TabIndex = 2;
      // 
      // txtCRC
      // 
      this.txtCRC.Enabled = false;
      this.txtCRC.Location = new System.Drawing.Point(344, 3);
      this.txtCRC.Name = "txtCRC";
      this.txtCRC.Size = new System.Drawing.Size(196, 20);
      this.txtCRC.TabIndex = 1;
      // 
      // txtManaCost
      // 
      this.txtManaCost.Enabled = false;
      this.txtManaCost.Location = new System.Drawing.Point(74, 3);
      this.txtManaCost.Name = "txtManaCost";
      this.txtManaCost.Size = new System.Drawing.Size(196, 20);
      this.txtManaCost.TabIndex = 1;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(274, 7);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(67, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Coste Mana:";
      // 
      // lblMana
      // 
      this.lblMana.AutoSize = true;
      this.lblMana.Location = new System.Drawing.Point(4, 7);
      this.lblMana.Name = "lblMana";
      this.lblMana.Size = new System.Drawing.Size(67, 13);
      this.lblMana.TabIndex = 0;
      this.lblMana.Text = "Coste Mana:";
      // 
      // textBox3
      // 
      this.textBox3.Location = new System.Drawing.Point(53, 3);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(489, 20);
      this.textBox3.TabIndex = 1;
      // 
      // lblManaCost
      // 
      this.lblManaCost.AutoSize = true;
      this.lblManaCost.Location = new System.Drawing.Point(4, 7);
      this.lblManaCost.Name = "lblManaCost";
      this.lblManaCost.Size = new System.Drawing.Size(67, 13);
      this.lblManaCost.TabIndex = 0;
      this.lblManaCost.Text = "Coste Mana:";
      // 
      // panel4
      // 
      this.panel4.BackColor = System.Drawing.Color.DarkGray;
      this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel4.Controls.Add(this.txtOriginal);
      this.panel4.Controls.Add(this.lblOriginalName);
      this.panel4.Location = new System.Drawing.Point(6, 53);
      this.panel4.Name = "panel4";
      this.panel4.Size = new System.Drawing.Size(547, 28);
      this.panel4.TabIndex = 0;
      // 
      // txtOriginal
      // 
      this.txtOriginal.Enabled = false;
      this.txtOriginal.Location = new System.Drawing.Point(74, 3);
      this.txtOriginal.Name = "txtOriginal";
      this.txtOriginal.Size = new System.Drawing.Size(468, 20);
      this.txtOriginal.TabIndex = 1;
      // 
      // lblOriginalName
      // 
      this.lblOriginalName.AutoSize = true;
      this.lblOriginalName.Location = new System.Drawing.Point(4, 7);
      this.lblOriginalName.Name = "lblOriginalName";
      this.lblOriginalName.Size = new System.Drawing.Size(21, 13);
      this.lblOriginalName.TabIndex = 0;
      this.lblOriginalName.Text = "ID:";
      // 
      // panelName
      // 
      this.panelName.BackColor = System.Drawing.Color.DarkGray;
      this.panelName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panelName.Controls.Add(this.label2);
      this.panelName.Controls.Add(this.txtName);
      this.panelName.Controls.Add(this.lblCardName);
      this.panelName.Location = new System.Drawing.Point(6, 19);
      this.panelName.Name = "panelName";
      this.panelName.Size = new System.Drawing.Size(547, 28);
      this.panelName.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(403, 7);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Nombre";
      // 
      // txtName
      // 
      this.txtName.Enabled = false;
      this.txtName.Location = new System.Drawing.Point(74, 3);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(323, 20);
      this.txtName.TabIndex = 1;
      // 
      // lblCardName
      // 
      this.lblCardName.AutoSize = true;
      this.lblCardName.Location = new System.Drawing.Point(4, 7);
      this.lblCardName.Name = "lblCardName";
      this.lblCardName.Size = new System.Drawing.Size(44, 13);
      this.lblCardName.TabIndex = 0;
      this.lblCardName.Text = "Nombre";
      // 
      // proxyImage
      // 
      this.proxyImage.BackColor = System.Drawing.Color.Transparent;
      this.proxyImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.proxyImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.proxyImage.InitialImage = ((System.Drawing.Image)(resources.GetObject("proxyImage.InitialImage")));
      this.proxyImage.Location = new System.Drawing.Point(806, 3);
      this.proxyImage.Name = "proxyImage";
      this.proxyImage.Size = new System.Drawing.Size(471, 657);
      this.proxyImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.proxyImage.TabIndex = 2;
      this.proxyImage.TabStop = false;
      // 
      // lblDeckTitle
      // 
      this.lblDeckTitle.AutoSize = true;
      this.lblDeckTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDeckTitle.Location = new System.Drawing.Point(7, 6);
      this.lblDeckTitle.Name = "lblDeckTitle";
      this.lblDeckTitle.Size = new System.Drawing.Size(165, 20);
      this.lblDeckTitle.TabIndex = 2;
      this.lblDeckTitle.Text = "Constructor de Mazos";
      // 
      // DeckForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
      this.ClientSize = new System.Drawing.Size(1280, 720);
      this.Controls.Add(this.lblDeckTitle);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menu;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DeckForm";
      this.Text = "Constructor de Mazos";
      this.menu.ResumeLayout(false);
      this.menu.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.panelDeck.ResumeLayout(false);
      this.panel3.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.cardBox.ResumeLayout(false);
      this.panel10.ResumeLayout(false);
      this.panel10.PerformLayout();
      this.panel14.ResumeLayout(false);
      this.panel14.PerformLayout();
      this.panel13.ResumeLayout(false);
      this.panel13.PerformLayout();
      this.panel12.ResumeLayout(false);
      this.panel12.PerformLayout();
      this.panel11.ResumeLayout(false);
      this.panel11.PerformLayout();
      this.panel9.ResumeLayout(false);
      this.panel9.PerformLayout();
      this.panel8.ResumeLayout(false);
      this.panel8.PerformLayout();
      this.panel5.ResumeLayout(false);
      this.panel5.PerformLayout();
      this.panel6.ResumeLayout(false);
      this.panel6.PerformLayout();
      this.panel4.ResumeLayout(false);
      this.panel4.PerformLayout();
      this.panelName.ResumeLayout(false);
      this.panelName.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.proxyImage)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem libreriaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cargarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem theGathererToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panelDeck;
    private System.Windows.Forms.Button btnAddNewCard;
    private System.Windows.Forms.ListBox listCards;
    private System.Windows.Forms.Label lblDeckTitle;
    private System.Windows.Forms.Panel panel3;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.PictureBox proxyImage;
    private System.Windows.Forms.GroupBox cardBox;
    private System.Windows.Forms.Panel panelName;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.Label lblCardName;
    private System.Windows.Forms.Panel panel10;
    private System.Windows.Forms.TextBox txtToughtness;
    private System.Windows.Forms.TextBox txtPower;
    private System.Windows.Forms.Label lblToughtness;
    private System.Windows.Forms.Label lblPower;
    private System.Windows.Forms.Panel panel14;
    private System.Windows.Forms.TextBox txtArtist;
    private System.Windows.Forms.Label lblArtist;
    private System.Windows.Forms.Panel panel13;
    private System.Windows.Forms.TextBox txtNumber;
    private System.Windows.Forms.Label lblNumber;
    private System.Windows.Forms.Panel panel12;
    private System.Windows.Forms.TextBox txtRarity;
    private System.Windows.Forms.Label lblRarity;
    private System.Windows.Forms.Panel panel11;
    private System.Windows.Forms.TextBox txtCollection;
    private System.Windows.Forms.Label lblSet;
    private System.Windows.Forms.Panel panel9;
    private System.Windows.Forms.TextBox txtText;
    private System.Windows.Forms.Label lblText;
    private System.Windows.Forms.Panel panel8;
    private System.Windows.Forms.TextBox txtType;
    private System.Windows.Forms.Label lblType;
    private System.Windows.Forms.Panel panel5;
    private System.Windows.Forms.Panel panel6;
    private System.Windows.Forms.TextBox txtCRC;
    private System.Windows.Forms.TextBox txtManaCost;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblMana;
    private System.Windows.Forms.TextBox textBox3;
    private System.Windows.Forms.Label lblManaCost;
    private System.Windows.Forms.Panel panel4;
    private System.Windows.Forms.TextBox txtOriginal;
    private System.Windows.Forms.Label lblOriginalName;
    private System.Windows.Forms.Label label2;
  }
}