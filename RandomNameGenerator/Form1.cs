using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomNameGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Generate_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] nameArray = initializeList();

            string randomName = nameArray[rnd.Next(nameArray.Length)];

            lbl_Name.Text = randomName;
        }

        public static string[] initializeList()
        {
            string[] nameArray = new string[50];

            string names = "Leota,Luci,Sherrill,Tessa,Germaine,Laquanda,Ellamae,Gregory,Filomena,Clement,Keenan,Miguelina,Ethyl,Patsy,Chau,Cythia,Francis,Josiah,Etta,Burma,Chan,Andy,Rossie,Clayton,Natalya,Kandra,Agripina,Gaylord,Novella,Merlyn,Jeni,Deangelo,Lynwood,Catherina,Shu,Tilda,Bradly,Hiram,Marnie,Lang,Johana,Jadwiga,Elizebeth,Benjamin,Setsuko,Rebbecca,Lashay,Olympia,Audry,Janina";

            nameArray=names.Split(',');

            return nameArray;
        }
    }
}
