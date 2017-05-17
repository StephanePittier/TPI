///ETML
///Auteur : Stéphane Pittier
///Date : 10.05.2017
///Description : Permet d' effectuer une opération arithmétique de type + - * /
///              avec deux valeurs en Décimal | Binaire | Octal | Hexadécimal
///              
 
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
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            char[] splitters = new char[] { '|' };
            string test = Convert.ToString(type1ComboBox.SelectedItem);
            string test2 = Convert.ToString(type2ComboBox.SelectedItem);

            string[] basetype = test.Split(splitters);
            int baseNumber1 = Convert.ToInt32(basetype[1]);
            

            basetype = test2.Split(splitters);
            int baseNumber2 = Convert.ToInt32(basetype[1]);

            string valueBase1 = value1TextBox.Text;
            string valueBase2 = value2TextBox.Text;

            string operation = Convert.ToString(operationsComboBox.SelectedItem);

            calcualteValues(valueBase1, valueBase2, baseNumber1, baseNumber2, operation);

        }

        private void calcualteValues (string userValue1, string userValue2 , int userBase1, int userBase2, string userOperation)
        {
            int value1 = Convert.ToInt32(userValue1, userBase1);
            int value2 = Convert.ToInt32(userValue2, userBase2);
            string result = "";
            

            if (userBase1 == userBase2)
            {
                if(userValue1.Length < userValue2.Length)
                {             
                    int maxZero = userValue2.Length - userValue1.Length;
                    for (int i = 0; i < maxZero; i++)
                    {
                        userValue1 = "0" + userValue1;
                    }         
                }
                else if (userValue1.Length > userValue2.Length)
                {
                    
                    int maxZero = userValue1.Length - userValue2.Length;
                    for (int i = 0; i < maxZero; i++)
                    {
                        userValue2 = "0" + userValue2;
                    }
                }
                int[] retenue = new int[userValue1.Length];
                    addValue(userValue1, userValue2,userBase1, result, retenue);
            }
            else
            {
                
                
                
            }
        }

        /// <summary>
        /// Fonction permettant d'effectuer une addition en colone entre 2 valeurs de meme base entrée par l'utilisateur.
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="retenue">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void addValue(string value1, string value2,int baseValue, string result, int[] retenue)
        {
            
            retenue[value1.Length-1] = 0;
            
            for (int i = value1.Length-1; i >= 0; i--)
            {
                string d = Convert.ToString(value1[i]);
                string e = Convert.ToString(value2[i]);

                int f = Convert.ToInt32(d);
                int g = Convert.ToInt32(e);

                if (f+g+retenue[i] >= baseValue)
                {
                    result = Convert.ToString(f + g + retenue[i] - baseValue) +result;
                    if (i - 1 >= 0)
                    {
                        retenue[i - 1] = 1;
                    }
                }
                else
                {
                    result = Convert.ToString(f + g + retenue[i])+result;
                    if(i-1>=0)
                    {
                        retenue[i - 1] = 0;
                    }                 
                }
            }
        }
        

        private void substractValue(string value1, string value2, int baseValue, string result, int[] retenue)
        {
            retenue[value1.Length - 1] = 0;

            for (int i = value1.Length - 1; i >= 0; i--)
            {
                string d = Convert.ToString(value1[i]);
                string e = Convert.ToString(value2[i]);

                int f = Convert.ToInt32(d);
                int g = Convert.ToInt32(e);

                if (f + retenue[i] - g >= 0)
                {
                    result = Convert.ToString(f + retenue[i] - g) + result;
                    
                }
                else
                {
                    string temp = Convert.ToString(value1[i - 1]);
                    int h = Convert.ToInt32(temp);
                    h = h - 1;
                    //value1[i-1] = Convert.ToString(h);
                    retenue[i] = 10;
                    result = Convert.ToString(f + retenue[i]- g) + result;
                    

                }
            }
        }


    }
}
