///ETML
///Auteur : Stéphane Pittier
///Date : 10.05.2017
///Description : Programme qui récupère les valeurs d'un utilisateur 
///              pour les convertir dans les 6 formats suivants
///              Décimal | Binaire | Octal | Hexadécimal
///              Code BCD | Code Gray
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConvertisseurNumerique
{
    public partial class FormConverter : Form
    {
        ///
        private Form Calculator;
        /// 

        public FormConverter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            Calculator = new FormCalculator();
            Calculator.Show();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            checkIntegrityValue();

            string value = valueTextBox.Text;

            char[] splitters = new char[] { '|' };
            string test = Convert.ToString(typesComboBox.SelectedItem);
            string[] laCase = test.Split(splitters);

            int baseType = Convert.ToInt32(laCase[1]);

            int binary = Convert.ToInt32(value, baseType);



            binaryTextBox.Text = Convert.ToString(binary, 2);
            octalTextBox.Text = Convert.ToString(binary, 8);
            decimalTextBox.Text = Convert.ToString(binary, 10);
            hexaTextBox.Text = Convert.ToString(binary, 16);

            convertToBcd(decimalTextBox.Text);



        }
        /// <summary>
        /// Vérifie que l'utilisateur entre une valeur correcte avec le type
        /// </summary>
        private void checkIntegrityValue()
        {
            if (valueTextBox.Text == "" || typesComboBox.SelectedItem == null)
                MessageBox.Show("Veuillez choisir un type et une valeur !");
        }

        /// <summary>
        /// Permet de convertir la valeur de l'utilisateur en code BCD
        /// </summary>
        /// <param name="valueDecimal"></param>
        private void convertToBcd(string valueDecimal)
        {
            int max = valueDecimal.Length;
            string[] bcd = new string[max];

            for (int i = 0; i < max; i++)
            {
                string temp = Convert.ToString(valueDecimal[i]);
                int num = Convert.ToInt32(temp);
                temp = Convert.ToString(num, 2);
                int taille = temp.Length;
                if(taille != 4)
                {
                    
                }
                bcd[i] = temp;                
            }

           

           
        }
    }
}
