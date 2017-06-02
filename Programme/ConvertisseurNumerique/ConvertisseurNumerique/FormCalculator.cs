///ETML
///Auteur : Stéphane Pittier
///Date : 10.05.2017
///Description : Permet d' effectuer une opération arithmétique de type + - * /
///              avec deux valeurs en Décimal | Binaire | Octal | Hexadécimal
///              

using System;
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
        /// Fonction permettant de préparer les  valeurs pour les opérations
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            char[] splitters = new char[] { '|' };
            string test = Convert.ToString(type1ComboBox.SelectedItem);
            string test2 = Convert.ToString(type2ComboBox.SelectedItem);
            string operation = Convert.ToString(operationsComboBox.SelectedItem);

            string valueBase1 = value1TextBox.Text;
            string valueBase2 = value2TextBox.Text;

            //Si les informations de bases ne sont pas entrées, avertit l'utilisateur
            if (test == "" || test2 == "" || valueBase1 == "" || valueBase2 == "" || operation == "")
            {
                MessageBox.Show("Pour lancer une opération, les 2 valeurs ainsi que leur type et un opératuer doivent être séléctionné !");
            }
            else
            {
                string[] basetype = test.Split(splitters);
                int baseNumber1 = Convert.ToInt32(basetype[1]);
                basetype = test2.Split(splitters);
                int baseNumber2 = Convert.ToInt32(basetype[1]);

                //Permet de lancer les opérations
                calcualteValues(valueBase1, valueBase2, baseNumber1, baseNumber2, operation);
            }
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
            string result = "";
            //string[] result = new string[userValue1.Length+1];

            //Initialisation valeur du switch 
            const string ADD = "+";
            const string DIMINUED = "-";
            const string MULTIPLICATE = "*";
            const string DIVIDE = "/";



            //Vérifie que les 2 valeurs ont bien la meme base. si non va convertir la valeur 2 avec la base 1
            if (userBase1 != userBase2)
            {
                int temp = Convert.ToInt32(userValue2, userBase2);
                userValue2 = Convert.ToString(temp, userBase1);
            }
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
                int[] retenue = new int[userValue1.Length];

            //Permet de choisir la bonne fonction pour chaque opérations
            switch(userOperation)
            {
                case ADD:
                    {
                        addValue(userValue1, userValue2, userBase1, result, retenue);
                        break;
                    }
                case DIMINUED:
                    {
                        substractValue(userValue1, userValue2, userBase1, result, retenue);
                        break;
                    }
                case MULTIPLICATE:
                    {
                        multipliacateValue(userValue1, userValue2, userBase1);
                        break;

                    }
                case DIVIDE:
                    {
                        divideValue(userValue1, userValue2);
                        break;
                    }
            }           
        }

        /// <summary>
        /// Fonction permettant d'effectuer une addition en colone entre 2 valeurs de meme base entrée par l'utilisateur.
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="restraint">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void addValue(string value1, string value2,int baseValue, string result, int[] restraint)
        {
            
            restraint[value1.Length-1] = 0;
            
            //pour chaque chiffre de la valeur va récuperer les 2 chiffre à additionner
            for (int i = value1.Length-1; i >= 0; i--)
            {
                string stringValue1Unit = Convert.ToString(value1[i]);
                string stringValue2Unit = Convert.ToString(value2[i]);

                int intValue1Unit = Convert.ToInt32(stringValue1Unit);
                int intValue2Unit = Convert.ToInt32(stringValue2Unit);

                //Permet de verifier les valeurs et ainsi de placer les retenues adéquates
                if (intValue1Unit + intValue2Unit + restraint[i] >= baseValue)
                {
                    result = Convert.ToString(intValue1Unit + intValue2Unit + restraint[i] - baseValue) + result;
                    if (i - 1 >= 0)
                    {
                        restraint[i - 1] = 1;
                    }
                    else
                    {
                        result = "1" + result;
                    }
                }
                //sinon il va juste effectuer l'opération et place une retenue à 0 pour la suite du calcule
                else
                {
                    result = Convert.ToString(intValue1Unit + intValue2Unit + restraint[i]) + result;
                    if (i - 1 >= 0)
                    {
                        restraint[i - 1] = 0;
                    }
                }
            }

            showResult(value1, value2, result);
        }

        /// <summary>
        /// Fonction permettant d'effectuer une soustraction en colone entre 2 valeurs de meme base entrée par l'utilisateur.
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        /// <param name="result">Stock et permet l'affichage du résultat</param>
        /// <param name="restraint">Tableau de int permettant de stocker les retenues lors de l'addition en colone. Est aussi utilisée lors de l'affichage</param>
        private void substractValue(string value1, string value2, int baseValue, string result, int[] restraint)
        {
            char[] charValue1 = value1.ToCharArray();
            restraint[value1.Length - 1] = 0;

            //pour chaque chiffre effectue une soustraction et place les retenues dans le tableau à l'index actuel
            for (int i = value1.Length - 1; i >= 0; i--)
            {
                string stringValue1Unit = Convert.ToString(charValue1[i]);
                string stringValue2Unit = Convert.ToString(value2[i]);

                int intValue1Unit = Convert.ToInt32(stringValue1Unit);
                int intValue2Unit = Convert.ToInt32(stringValue2Unit);

                //si la soustraction est supérieur à 0 le programme ne va pas placer de retenues
                if (intValue1Unit + restraint[i] - intValue2Unit >= 0)
                {
                    result = Convert.ToString(intValue1Unit + restraint[i] - intValue2Unit) + result;
                    
                }
                //sinon le programme diminue le chiffre suivant de 1 est place la base en retenue de la valeur actuelle
                else
                {
                    string temp = Convert.ToString(value1[i - 1]);
                    int valueDiminued = Convert.ToInt32(temp);
                    temp = Convert.ToString(valueDiminued - 1);
                    charValue1[i-1] = Convert.ToChar(temp);
                    restraint[i] = baseValue;
                    result = Convert.ToString(intValue1Unit + restraint[i]- intValue2Unit) + result;
                }
            }
            showResult(value1, value2, result);
        }

        /// <summary>
        /// Fonction permettant d'effectuer une multiplication en colone entre 2 valeurs de meme base entrée par l'utilisateur.
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        /// <param name="baseValue">Prends la base de la valeur 1 ou 2 pour afficher le résultat en fonction</param>
        private void multipliacateValue(string value1, string value2, int baseValue)
        {
            //Contrairement aux autres fonctions, vu que ce sont des tableaux à 2 dimensions, ils sont déclaré dnas la fonction
            string[,] result = new string[value1.Length, value1.Length+2];
            int[,] restraint = new int[value1.Length, value1.Length+2];


            //première retenue toujours à 0
            restraint[value1.Length - 1, value2.Length - 1] = 0;

            //Recupère chaque unité des 2 valeurs 
            for (int i = value1.Length - 1; i >= 0; i--)
            {
                int tempRestraint = 0;
                string unitValue1 = Convert.ToString(value1[i]);
                int factor1 = Convert.ToInt32(unitValue1);
                int counterRestraint = value1.Length+1;

                //permet de rajouter les 0 entre chaque niveau de la multiplications
                int difference = value1.Length - 1 - i;
                if (difference > 0)
                {
                    for (int j = difference; j > 0; j--)
                    {
                        result[i, counterRestraint] = Convert.ToString(0);
                        counterRestraint--;
                    }
                }
                
                for (int y = value2.Length - 1; y >= 0; y--)
                {
                    string unitValue2 = Convert.ToString(value2[y]);
                    int factor2 = Convert.ToInt32(unitValue2);

                    //vérifie la valeur de la multiplications et mets les bon elements au bon endroits
                    if (factor1 * factor2 + tempRestraint < baseValue)
                    {
                        result[i, counterRestraint] = Convert.ToString(factor1 * factor2 + tempRestraint);
                        tempRestraint = restraint[i, counterRestraint];
                    }
                    else
                    {
                        string temp = Convert.ToString(factor1 * factor2 + tempRestraint);
                        result[i, counterRestraint] = Convert.ToString(temp[1]);
                        temp = Convert.ToString(temp[0]);
                        restraint[i, counterRestraint] = Convert.ToInt32(temp);
                        tempRestraint = restraint[i, counterRestraint];
                    }

                    if (y == 0)
                    {
                        result[i, y] = Convert.ToString(tempRestraint);
                    }

                    counterRestraint--;
                }
            }
            //Création des valeurs résultats pour les additionner entre elle
            val1ResultTextBox.Text = value1;
            val2ResultTextBox.Text = value2;

            resultTextBox.Text = Convert.ToString(Convert.ToInt32(value1) * Convert.ToInt32(value2));
        }
        /// end multipliacateValue

        /// <summary>
        /// Fonction permettant d'effectuer une division en colone entre 2 valeurs de meme base entrée par l'utilisateur.
        /// </summary>
        /// <param name="value1">Valeur 1 de l'utilisateur convertie dans son format</param>
        /// <param name="value2">Valeur 2 de l'utilisateur convertie dans son format</param>
        private void divideValue(string value1, string value2)
        {
            //Effectue une simple division entre les nombres
            int valueA = Convert.ToInt32(value1);
            int valueB = Convert.ToInt32(value2);

            string result = Convert.ToString(valueA / valueB);
            showResult(value1, value2, result);
        }

        /// <summary>
        /// Fonction permettant d'afficher le rsultat de l'opération en colone.
        /// </summary>
        /// <param name="value1"></param>
        /// <param name="value2"></param>
        /// <param name="result"></param>
        private void showResult(string value1, string value2, string result)
        {            
            val1ResultTextBox.Text = value1;
            val2ResultTextBox.Text = value2;
            resultTextBox.Text = result;
        }
    }
}
