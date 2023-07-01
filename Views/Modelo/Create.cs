using Controllers;
using Models;
using System.Windows.Forms;

namespace Views{

    public class ModeloCreate : Form{
        public Label lblNomemodelo;
        public TextBox txtNomemodelo;
        public Button btCadModelo;
        
          public void btCadModelo_Click(object sender, EventArgs e) {
            if (txtNomemodelo.Text == "") {
                MessageBox.Show("Preencha os campos");
                return;
            } else {
                ModeloController.Create(txtNomemodelo.Text);
                MessageBox.Show("Modelo criado com sucesso");  
            }
        }


        public ModeloCreate(){
            this.Text = "Registrar Modelo";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Size = new System.Drawing.Size(251,200);

            this.lblNomemodelo = new Label();
            this.lblNomemodelo.Text = "Modelo:";
            this.lblNomemodelo.Location = new Point(10, 50); // Horizontal, Vertical
            this.lblNomemodelo.Size = new Size(50, 20); // Largura, Altura

            this.txtNomemodelo = new TextBox();
            this.txtNomemodelo.Location = new Point(80, 50);
            this.txtNomemodelo.Size = new Size(100, 20);

            this.btCadModelo = new Button();
            this.btCadModelo.Text = "Cadastrar";
            this.btCadModelo.Location = new Point(10, 100);
            this.btCadModelo.Size = new Size(70, 20);
            // btCadModelo.Click += btCadModelo_Click;

            Controls.Add(lblNomemodelo);
            Controls.Add(txtNomemodelo);
            Controls.Add(btCadModelo);
        }
    }
}