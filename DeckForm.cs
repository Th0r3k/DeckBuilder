using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTGDeckBuilder.Deck
{
  public partial class DeckForm : Form
  {
    DataBaseForm oDataBase = new DataBaseForm();
    Deck oDeck = new Deck();
    private const int WM_NCHITTEST = 0x84;
    private const int HTCLIENT = 0x1;
    private const int HTCAPTION = 0x2;
    protected override void WndProc(ref Message message)
    {
      base.WndProc(ref message);

      if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
        message.Result = (IntPtr)HTCAPTION;
    }
    public DeckForm()
    {
      InitializeComponent();
      proxyImage.Image = Image.FromFile("data/cards/cardBack.png");
    }

    private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void salirToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void cargarToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void theGathererToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Deck.m_oDatabase.UpdateDatabaseFromTheGatherer();
    }

    private void btnAddNewCard_Click(object sender, EventArgs e)
    {
      oDataBase.ShowDialog();
      if(oDataBase.oSelectedCard != null)
      {
        oDeck.m_lstCards.Add(oDataBase.oSelectedCard);
        listCards.Items.Add(oDataBase.oSelectedCard);
      }
    }

    private void listCards_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (listCards.SelectedItem is DataBase.Card)
      {
        DataBase.Card oCard = listCards.SelectedItem as DataBase.Card;
        proxyImage.Image = Image.FromFile(oCard.GetImagePath());
        cardBox.Text = oCard.sCardName;
        txtArtist.Text = oCard.sArtist;
        txtCollection.Text = oCard.sSet;
        txtCRC.Text = oCard.iCMC.ToString();
        txtText.Text = "";
        foreach(string sLine in oCard.sText)
          txtText.Text += sLine + "\n";
        txtPower.Text = oCard.iPower.ToString();
        txtToughtness.Text = oCard.iToughness.ToString();
        txtType.Text = oCard.sType;
        txtRarity.Text = oCard.eRarity;
        txtNumber.Text = oCard.iSetNumber.ToString();
        txtName.Text = oCard.sCardName;
        txtOriginal.Text = oCard.sCardOriginalName;
        //proxyImage.Image. = 456;
        //proxyImage.Image.Height = 636;
      }
    }

  }
}
