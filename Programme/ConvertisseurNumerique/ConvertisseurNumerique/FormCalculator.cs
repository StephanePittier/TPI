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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Fonction permettant de mettre toutes les  valeurs à la meme base et au meme nombre de chiffre
        /// </summary>
        /// <param name="userValue1"></param>
        /// <param name="userValue2"></param>
        /// <param name="userBase1"></param>
        /// <param name="userBase2"></param>
        /// <param name="userOperation"></param>
        private void calcualteValues (string userValue1, string userValue2 , int userBase1, int userBase2, string userOperation)
        {
            int value1 = Convert.ToInt32(userValue1, userBase1);
            int value2 = Convert.ToInt32(userValue2, userBase2);
            //string result = "";
            string[] result = new string[userValue1.Length+1];


            //Va vérifier la longueur des caractère si ils sont de meme base
            if (userBase1 == userBase2)
            {
                //Vérification des nombres pour etre sure que les opérations se passe bien
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
                //divideValue(userValue1, userValue2);
            }
            //Va convertire la valeur 1 et la valeur 2 dans le base de l'autre, Et lancer 2 fois l'opération
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
            
            //pour chaque chiffre de la valeur va récuperer les 2 chiffre à additionner
            for (int i = value1.Length-1; i >= 0; i--)
            {
                string stringValue1Unit = Convert.ToString(value1[i]);
                string stringValue2Unit = Convert.ToString(value2[i]);

                int intValue1Unit = Convert.ToInt32(stringValue1Unit);
                int intValue2Unit = Convert.ToInt32(stringValue2Unit);

                //Permet de verifier les valeurs et ainsi de placer les retenues adéquates
                if (intValue1Unit + intValue2Unit + retenue[i] >= baseValue)
                {
                    result = Convert.ToString(intValue1Unit + intValue2Unit + retenue[i] - baseValue) + result;
                    if (i - 1 >= 0)
                    {
                        retenue[i - 1] = 1;
                    }
                    else
                    {
                        result = "1" + result;
                    }
                }
                //sinon il va juste effectuer l'opération et place une retenue à 0 pour la suite du calcule
                else
                {
                    result = Convert.ToString(intValue1Unit + intValue2Unit + retenue[i]) + result;
                    if (i - 1 >= 0)
                    {
                        retenue[i - 1] = 0;
                    }
                }
            }
        }

        /// <summary>
        /// Fonction permettant d'effectuer une soustraction en colone entre 2 valeurs de meme base entrée par l'utilisateur.
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
                string stringValue1Unit = Convert.ToString(value1[i]);
                string stringValue2Unit = Convert.ToString(value2[i]);

                int intValue1Unit = Convert.ToInt32(stringValue1Unit);
                int intValue2Unit = Convert.ToInt32(stringValue2Unit);

                //si la soustraction est supérieur à 0 le programme ne va pas placer de retenues
                if (intValue1Unit + retenue[i] - intValue2Unit >= 0)
                {
                    result = Convert.ToString(intValue1Unit + retenue[i] - intValue2Unit) + result;
                    
                }
                //sinon le programme diminue le chiffre suivant de 1 est place la base-1 en retenue de la valeur actuelle
                else
                {
                    string temp = Convert.ToString(value1[i - 1]);
                    int valueDiminued = Convert.ToInt32(temp);                   
                    //value1[i-1] = Convert.ToString(valueDiminued-1);
                    retenue[i] = baseValue;
                    result = Convert.ToString(intValue1Unit + retenue[i]- intValue2Unit) + result;
                }
            }
        }

        /// <summary>
        /// Fonction permettant d'effectuer une multiplication en colone entre 2 valeurs de meme base entrée par l'utilisateur.
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="retenue">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void multipliacateValue(string value1, string value2, int baseValue, string[] result, int[,] retenue)
        {
            retenue[value1.Length-1, value1.Length] = 0;

            //Prend le premier chiffre de la valeur 1 pour le multiplier avec les autres
            for (int i = value1.Length-1; i >=0 ; i--)
            {
                string stringValue1Unit = Convert.ToString(value1[i]);
                int intValue1Unit = Convert.ToInt32(stringValue1Unit);

                //Prends chaque chiffre de la valeur 2 et le multiplie avec celle de 1.
                for (int y = value2.Length-1; y >=0; y--)
                {
                    string stringValue2Unit = Convert.ToString(value2[y]);
                    int intValue2Unit = Convert.ToInt32(stringValue2Unit);

                    int temp = intValue1Unit * intValue2Unit + retenue[i, i + 1];

                    //Permet de placer les retenues si le résultat est plus grand que la base des chiffres
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
        /// Fonction permettant d'effectuer une division en colone entre 2 valeurs de meme base entrée par l'utilisateur.
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