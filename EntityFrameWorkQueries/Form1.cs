using EntityFrameWorkQueries.Data;
using EntityFrameWorkQueries.Models;

namespace EntityFrameWorkQueries
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new APContext();

            //LINQ (Language Intergrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors.ToList();// From Data/APContext/Vendor/Vendors

            //LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       select v).ToList();


        }
    }
}