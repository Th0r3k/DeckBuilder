using System;
using System.Windows.Forms;
using MTGDeckBuilder.DataBase;
using System.Drawing;
namespace MTGDeckBuilder
{
  public partial class DataBaseForm : Form
  {
    private Database oDataBase = new Database();
    public Card oSelectedCard = null;


    private TreeNodeCollection baseNodes = (new TreeView()).Nodes;
    private const int WM_NCHITTEST = 0x84;
    private const int HTCLIENT = 0x1;
    private const int HTCAPTION = 0x2;

    private const string sTypeNombre = "Nombre";
    private const string sTypeNombreOriginal = "Nombre Original";
    private const string sTypeTipo = "Tipo";
    private const string sTypeTexto = "Texto";
    private const string sTypeRareza = "Rareza";
    private const string sTypeColor = "Color";

    private string sLastFilter = "";

    protected override void WndProc(ref Message message)
    {
      base.WndProc(ref message);

      if (message.Msg == WM_NCHITTEST && (int)message.Result == HTCLIENT)
        message.Result = (IntPtr)HTCAPTION;
    }
    public DataBaseForm()
    {
      InitializeComponent();
      oDataBase.Load(baseNodes);
      RestoreTree();
      comboSearch.Items.Add(sTypeNombre);
      comboSearch.Items.Add(sTypeNombreOriginal);
      comboSearch.Items.Add(sTypeTipo);
      comboSearch.Items.Add(sTypeTexto);
      comboSearch.Items.Add(sTypeRareza);
      comboSearch.Items.Add(sTypeColor);
      pbxProxy.Image = Image.FromFile("data/cards/cardBack.png");
    }
    private void RestoreTree()
    {
      foreach (TreeNode NodeSet in baseNodes)
      {
        TreeNode thisSetNode = null;
        thisSetNode = treeSets.Nodes.Add(String.Copy(NodeSet.Text));
        thisSetNode.Tag = new Set(NodeSet.Tag as Set);
        foreach (TreeNode NodeCard in NodeSet.Nodes)
        {
          TreeNode copy = thisSetNode.Nodes.Add(NodeCard.Text);
          copy.Tag = new Card(NodeCard.Tag as Card);
        }
      }
    }
    private void treeSets_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (treeSets.SelectedNode.Tag is Card)
      {
        Card oSelected = treeSets.SelectedNode.Tag as Card;
        oSelectedCard = oSelected;
        pbxProxy.Image = Image.FromFile(oSelected.GetImagePath());
      }
      else
      {
        pbxProxy.Image = Image.FromFile("data/cards/cardBack.png");
        oSelectedCard = null;
        txtSearchField.Text = "";
      }
    }
    private void treeSets_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      Close();
    }
    private void btnAddCard_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void txtSearchField_TextChanged(object sender, EventArgs e)
    {
      treeSets.Nodes.Clear();
      if (txtSearchField.Text == "")
      {
        RestoreTree();
      }
      foreach (TreeNode NodeSet in baseNodes)
      {
        foreach (TreeNode NodeCard in NodeSet.Nodes)
        {
          bool bSelectable = false;
          switch (comboSearch.Text)
          {
            case sTypeNombre:
              if ((NodeCard.Tag as Card).sCardName.Contains(txtSearchField.Text))
                bSelectable = true;
              break;
            case sTypeNombreOriginal:
              if ((NodeCard.Tag as Card).sCardOriginalName.Contains(txtSearchField.Text))
                bSelectable = true;
              break;
            case sTypeTipo:
              if ((NodeCard.Tag as Card).sType.Contains(txtSearchField.Text))
                bSelectable = true;
              break;
            case sTypeTexto:
              foreach(string sLine in (NodeCard.Tag as Card).sText)
                if (sLine.Contains(txtSearchField.Text))
                  bSelectable = true;
              break;
            case sTypeRareza:
              if ((NodeCard.Tag as Card).eRarity.Contains(txtSearchField.Text))
                bSelectable = true;
              break;
            case sTypeColor:
              foreach (string sMana in (NodeCard.Tag as Card).sManaCost)
                if (sMana.Contains(txtSearchField.Text))
                  bSelectable = true;
              break;
          }
          if(bSelectable)
          {
            TreeNode copy = treeSets.Nodes.Add(NodeCard.Text);
            copy.Tag = new Card(NodeCard.Tag as Card);
          }
        }
      }
    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
