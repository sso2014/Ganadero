using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using G.Core.Data;

namespace G.Gui
{
    class CampoTreeView:TreeView
    {

        public CampoTreeView()
        {
            InitializeComponent();
         
        }

        private List<Campo> campos;
        private List<Establecimiento> establecimientos;
        private int index;
        private MenuStrip menuStrip1;
        private int indexCampo;

        public List<Establecimiento> DataEstablecimiento
        {
            set
            {
                establecimientos = value;
            }
        }

        public object DataSouce
        {
            set
            {

                campos = value as List<Campo>;

                if (establecimientos != null)
                {

                    TreeNode campoNodes = new TreeNode("*UNITEC BIO*");


                    this.Nodes.Clear();

                    foreach (Campo c in campos)
                    {
                        campoNodes.Nodes.Add(c.id.ToString(), c.Nombre);

                        foreach (TreeNode node in campoNodes.Nodes)
                        {
                            if (establecimientos != null)
                            {
                                foreach (Establecimiento es in establecimientos)
                                {
                                    if (node.Name == es.Campo_id.ToString())
                                    {
                                        if (es.Campo_id == c.id)
                                        {
                                            campoNodes.Nodes[node.Name].Nodes.Add(es.Id.ToString(), es.Nombre, 1, 2);
                                            campoNodes.Nodes[node.Name].Nodes[es.Id.ToString()].ImageIndex = 1;
                                        }
                                    
                                    }
                                   
                                }
                            }
                        }
                   }
                    this.Nodes.Add(campoNodes);
                    this.ExpandAll();            
                }
            }
        }

        public int SelectedIndexCampo {

            get {
                return indexCampo;
            }
        }

        public int SelectedIndexEstablecimiento {
            get {
                return index;
            }
        }       

        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // CampoTreeView
            // 
            this.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.CampoTreeView_NodeMouseClick);
            this.ResumeLayout(false);

        }

        private void CampoTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Level == 2){
                indexCampo = 0;
                index = Convert.ToInt32(e.Node.Name);

            }else if (e.Node.Level == 1){
                index = 0;
                indexCampo = Convert.ToInt32(e.Node.Name);
            }
        }
    }
}
