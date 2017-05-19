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
            //string result = "";
            string[] result = new string[userValue1.Length+1];



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
                int[,] retenue = new int[userValue1.Length,userValue1.Length+1];
                //addValue(userValue1, userValue2,userBase1, result, retenue);
                //substractValue(userValue1, userValue2,userBase1, result, retenue);
                //multipliacateValue(userValue1, userValue2, userBase1, result, retenue);
                divideValue(userValue1, userValue2);
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
                    else
                    {
                        result = "1" + result;
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="retenue">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void substractValue(string value1, string value2, int baseValue, string result, int[] retenue)
        {
            retenue[value1.Length - 1] = 0;

            //pour chaque chiffre effectue une soustraction et place les retenues dans le tableau à l'index actuel
            for (int i = value1.Length - 1; i >= 0; i--)
            {
                string d = Convert.ToString(value1[i]);
                string e = Convert.ToString(value2[i]);

                int f = Convert.ToInt32(d);
                int g = Convert.ToInt32(e);

                //si la soustraction est supérieur à 0 le programme ne va pas placer de retenues
                if (f + retenue[i] - g >= 0)
                {
                    result = Convert.ToString(f + retenue[i] - g) + result;
                    
                }
                //sinon le programme diminue le chiffre suivant de 1 est place la base-1 en retenue de la valeur actuelle
                else
                {
                    string temp = Convert.ToString(value1[i - 1]);
                    int h = Convert.ToInt32(temp);
                    h = h - 1;
                    //value1[i-1] = Convert.ToString(h);
                    retenue[i] = baseValue;
                    result = Convert.ToString(f + retenue[i]- g) + result;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="retenue">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void multipliacateValue(string value1, string value2, int baseValue, string[] result, int[,] retenue)
        {
            retenue[value1.Length-1, value1.Length] = 0;

            for (int i = value1.Length-1; i >=0 ; i--)
            {
                string d = Convert.ToString(value1[i]);
                int f = Convert.ToInt32(d);

                for (int y = value2.Length-1; y >=0; y--)
                {
                    string e = Convert.ToString(value2[y]);
                    int g = Convert.ToInt32(e);

                    int temp = f * g + retenue[i, i + 1];

                    if (temp >=baseValue)
                    {                       
                        string lol = Convert.ToString(temp);
                        retenue[i, y] = lol[0];
                        result[i] = lol[1]+result[i];
                    }
                    else
                    {
                        result[i] += Convert.ToString(temp);
                        retenue[i, i] = 0;
                    }
                }
                
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="retenue">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void divideValue(string value1, string value2)
        {
            int valueA = Convert.ToInt32(value1);
            int valueB = Convert.ToInt32(value2);

            string resultat = Convert.ToString(valueA / valueB);

            MessageBox.Show(resultat);
        }
    }
}