using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2hAtomikh2
{
    public partial class Atomikh2 : Form
    {
        int rows;           //Γραμμές
        int col;            //Στήλες
        int totalforms;     //Συνολικές Φόρμες που θα δημιουργηθούν
        int formWidth;      //Οι διαστάσεις της κάθε φόρμας (Πλάτος)
        int formHeight;     // (Ύψος)
        public Atomikh2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)        //ΌΤΑΝ ΠΑΤΗΘΕΊ ΚΟΥΜΠΊ
        {
            timer1.Enabled = true;                //Ενεργοποιεί το Timer
            rows = int.Parse(textBox1.Text);      //Δίνει τις τιμές του textbox στις σειρές
            col = int.Parse(textBox2.Text);       //στις στήλες
            totalforms = rows * col;              //Υπολογίζει τις συνολικές φόρμες      
            this.Location = new Point(0, 0);      //Τοποθετεί την φόρμα πάνω αριστερά ώστε να μπορεί ο χρήστης να ξανατρέξει το πρόγραμμα
        }

        private void timer1_Tick(object sender, EventArgs e)          //ΌΤΑΝ ΞΕΚΙΝΉΣΕΙ ΤΟ TIMER  
        {
            Atomikh2 f2 = new Atomikh2();                              //Δημιουργεί Φόρμα
            formWidth = Screen.PrimaryScreen.Bounds.Width / col;       //Δίνει τις διαστάσεις τις οθόνης
            formHeight = Screen.PrimaryScreen.Bounds.Height / rows;
            this.Size = new Size(600,400);                             //Μέγεθος κύριας φόρμας
            f2.Size = new Size(formWidth, formHeight);                 //Οι διαστάσεις
            int currentCol = (totalforms-1) % col;                     //Τρέχον στηλη
            int currentRow = (totalforms-1) / col;                      //Τρέχον σειρά
            f2.Location = new Point(currentCol * formWidth, currentRow * formHeight);    //Τοποθεσία φόρμας
            f2.StartPosition = FormStartPosition.Manual;               //Αρχική θέση φόρμας όταν ξεκινήσει το Timer
            Random random = new Random();                              //Τυχαία χρώματα
            Color randomColor = Color.FromArgb(random.Next(200),random.Next(200),random.Next(200));  //Διαστάσεις ανάμεσα στα χρώματα
            f2.BackColor = randomColor;                                //Αλλάζει το χρώμα κάθε φόρμας
            f2.Controls.Clear();                                       //Αδειάζει την φόρμα απτα controls
            Label label = new Label();                                 //Προσθέτει Label
            label.Text = "Good Evening Teacher -p21228\n" + (currentRow+1) + "," + (currentCol+1);  //Το Text του Label *Για κάποιο λόγο μου ξεκίναγε απο το μηδέν
            label.TextAlign = ContentAlignment.MiddleCenter;           //Θέση Text Label
            label.Dock = DockStyle.Fill;                               //Να καλύψει όλη την φόρμα ώστε να μπεί στο κέντρο
            f2.Controls.Add(label);                                    //Προσθέτουμε το Label στην φόρμα 
            f2.Show();                                                 //Εμφανίζει τις φόρμες
            totalforms--;                                              //Μειώνει τις φόρμες ώστε να μην δημιουργήσει παραπάνω
            if (totalforms <= 0)                        //Έλεγχος ώστε να τερματίσει το Timer όταν ολοκληρωθούν όλες οι φόρμες
            {
              timer1.Enabled = false;     
            }
                                                       //ΤΕΛΟΣ
        }

        
    }
}
