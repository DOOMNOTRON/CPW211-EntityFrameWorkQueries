using EntityFrameWorkQueries.Data;
using EntityFrameWorkQueries.Models;
using System.Text;

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

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       select v).ToList();


        }

        private void btnAllCaliVendors_Click(object sender, EventArgs e)
        {
            using APContext dbContext = new();

            // LINQ (Language Intergrated Query) method syntax
            List<Vendor> vendorList = dbContext.Vendors
                                        .Where(v => v.VendorState == "CA") //"" is for C# '' is for SQL
                                        .OrderBy(v => v.VendorName)
                                        .ToList();

            // LINQ query syntax
            List<Vendor> vendorList2 = (from v in dbContext.Vendors
                                       where v.VendorState == "CA"
                                       orderby v.VendorName
                                       select v).ToList();


        }

        private void btnSelectSpecificColumns_Click(object sender, EventArgs e)
        {
            APContext dbContext = new();
            
            // Anonymous
            List<VendorLocation> results = (from v in dbContext.Vendors
                          select new VendorLocation
                          { 
                              VendorName = v.VendorName, 
                              VendorState = v.VendorState, 
                              VendorCity = v.VendorCity
                          
                          }).ToList();
            
            StringBuilder displayString = new();

            foreach(VendorLocation vendor in results)
            {
                displayString.AppendLine($"{vendor.VendorName} is in {vendor.VendorCity}");
            }

            MessageBox.Show(displayString.ToString());
        }

        private void btnMiscQueries_Click(object sender, EventArgs e)
        {

            APContext dbContext = new();

            //Query Syntax
            // Check if a vendor exists in Washington
            bool doesExist = (from v in dbContext.Vendors
                              where v.VendorState == "WA"
                              select v).Any();

            // Get a number of Invoices
            int invoiceCount = (from invoices in dbContext.Invoices
                               select invoices).Count();

            // Query a single vendor
            Vendor ? singleVendor = (from v in dbContext.Vendors
                                     where v.VendorName == "IBM"
                                     select v).SingleOrDefault();

            if (singleVendor != null)
            {
                // Do something with the Vendor object

            }
        }
    }

    class VendorLocation
    {
        public string VendorName { get; set; }
        public string VendorState { get; set; }

        public string VendorCity { get; set; }
    }
}