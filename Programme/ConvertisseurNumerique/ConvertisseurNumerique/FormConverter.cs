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
        
        private Form Calculator;
        
        public FormConverter()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Affiche la fenetre pour effecteur les opérations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculatorButton_Click(object sender, EventArgs e)
        {
            Calculator = new FormCalculator();
            Calculator.Show();
        }

        /// <summary>
        /// Lance la conversion dans les 6 types disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void convertButton_Click(object sender, EventArgs e)
        {
            checkIntegrityValue();
            string exception = Convert.ToString(typesComboBox.SelectedItem);
            int baseNumber;


            if (exception == "Code BCD")
            {
                convertBcdToDecimal(valueTextBox.Text);
            }
            else if (exception == "Code GRAY")
            {
                convertGrayToBinary(valueTextBox.Text);
            }
            else
            {
                char[] splitters = new char[] { '|' };
                string test = Convert.ToString(typesComboBox.SelectedItem);
                string[] basetype = test.Split(splitters);

                 baseNumber = Convert.ToInt32(basetype[1]);
                 convertToAll(valueTextBox.Text, baseNumber);
            }         
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
        /// Permet de convertir dans les format du Binaire | Décimal | Octal | Hexadécimal
        /// </summary>
        /// <param name="userValue">Valeur entrée par l'utilisateur dans le textbox</param>
        /// <param name="baseType">base de la valeur obtenue avec le split dans la fonction convertButton_Click</param>
        private void convertToAll(string userValue, int baseType)
        {           
                int value = Convert.ToInt32(userValue, baseType);

            binaryTextBox.Text = Convert.ToString(value, 2);
            octalTextBox.Text = Convert.ToString(value, 8);
            decimalTextBox.Text = Convert.ToString(value, 10);
            hexaTextBox.Text = Convert.ToString(value, 16);

            convertToBcd(decimalTextBox.Text);
            convertToGray(binaryTextBox.Text);
        }

        /// <summary>
        /// Permet de convertir la valeur de l'utilisateur en code BCD
        /// </summary>
        /// <param name="decimalValue">Valeur décimale de la conversion en cours</param>
        private void convertToBcd(string decimalValue)
        {
            bcdTextBox.Text = "";

            //Separe la valeur en unité pour effectuer la conversion 
            for (int i = 0; i < decimalValue.Length; i++)
            {
                string temp = Convert.ToString(decimalValue[i]);
                int value = Convert.ToInt32(temp);
                temp = Convert.ToString(value, 2);
                
                //Tant que le chiffre n'est pas sur 4 bits rajoute un 0 devant
                if (temp.Length != 4)
                {
                    int maxZero = temp.Length;
                    for (int y = 0; y < 4 - maxZero; y++)
                    {
                        temp = "0" + temp;
                    }
                }

                bcdTextBox.Text += temp + " ";
            }
        }

        /// <summary>
        /// Permet de convertir le code BCD en code Décimal
        /// </summary>
        /// <param name="bcdValue"></param>
        private void convertBcdToDecimal(string bcdValue)
        {
            decimalTextBox.Text = "";
            char[] splitters = new char[] { ' ' };
            
            string[] laCase = bcdValue.Split(splitters);

            //Pour chaque ségment binaire ajoute la valeur en décimal au textbox
            for (int i = 0; i < laCase.Length; i++)
            {
                int convert = Convert.ToInt32(laCase[i], 2);
                
                decimalTextBox.Text += Convert.ToString(convert,10);
            }
            convertToAll(decimalTextBox.Text, 10);
        }

        /// <summary>
        /// Permet de convertir le binaire en code Gray
        /// Inspiré de  : http://stackoverflow.com/questions/1691074/gray-code-in-net
        /// /// <param name="binaryValue">Valeur Binaire de la conversion en cours</param>
        /// </summary>
        private void convertToGray(string binaryValue)
        {
            grayTextBox.Text = "";
            for (int i = 0; i < binaryValue.Length; i++)
            {
                if (i == 0)
                    grayTextBox.Text += binaryValue[0];
                else
                {
                    //Récupere chaque bit et effectue le complément à 2 avec le bit d'avant
                    string val1 = Convert.ToString(binaryValue[i]);
                    string val2 = Convert.ToString(binaryValue[i - 1]);

                    int test1 = Convert.ToInt32(val1);
                    int test2 = Convert.ToInt32(val2);

                    if (test1 + test2 == 0 || test1 + test2 == 2)
                        grayTextBox.Text += "0";
                    else
                        grayTextBox.Text += "1";

                }
            }
        }

        /// <summary>
        /// Permet de convertir le Code GRAY en binaire
        /// </summary>
        /// <param name="grayValue"></param>
        private void convertGrayToBinary(string grayValue)
        {
            binaryTextBox.Text = "";
            for (int i = 0; i < grayValue.Length; i++)
            {
                if (i == 0)
                    binaryTextBox.Text += grayValue[0];
                else
                {
                    string val1 = Convert.ToString(grayValue[i]);
                    string val2 = Convert.ToString(binaryTextBox.Text[i-1]);

                    int test1 = Convert.ToInt32(val1);
                    int test2 = Convert.ToInt32(val2);

                    if (test1 + test2 == 0 || test1 + test2 == 2)
                        binaryTextBox.Text += "0";
                    else
                        binaryTextBox.Text += "1";

                }
            }

            convertToAll(binaryTextBox.Text, 2);
        }
    }
}
