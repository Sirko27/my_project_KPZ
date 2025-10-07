using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лр10
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dbmanager = DBmanager.getInstance();
        }

        DBmanager dbmanager;
        Logger _Logger = Logger.getInstance();

        private void btnMySQL_connect_Click(object sender, EventArgs e)
        {
            if (dbmanager.ConnectMy())
                MessageBox.Show(";)");
            dbmanager.DisconnectMy();
        }

        Items items = new Items();
        List_product list_product = new List_product();
        Additional_items additional_items = new Additional_items();
        Product_package product_package = new Product_package();
        Target_user target_user = new Target_user();
        Type_product type_product = new Type_product();

        private void btnItems_Click(object sender, EventArgs e)
        {
            _Logger.Logging("Open table: " + ((Button)sender).Text);
            MessageBox.Show(_Logger.getLog());
            items.ShowDialog();
        }

        private void btnList_product_Click(object sender, EventArgs e)
        {
            _Logger.Logging("Open table: " + ((Button)sender).Text);
            MessageBox.Show(_Logger.getLog());
            list_product.ShowDialog();
        }

        private void btnAdditional_items_Click(object sender, EventArgs e)
        {
            _Logger.Logging("Open table: " + ((Button)sender).Text);
            MessageBox.Show(_Logger.getLog());
            additional_items.ShowDialog();
        }

        private void btnProduct_Package_Click(object sender, EventArgs e)
        {
            _Logger.Logging("Open table: " + ((Button)sender).Text);
            MessageBox.Show(_Logger.getLog());
            product_package.ShowDialog();
        }

        private void btnTarget_user_Click(object sender, EventArgs e)
        {
            _Logger.Logging("Open table: " + ((Button)sender).Text);
            MessageBox.Show(_Logger.getLog());
            target_user.ShowDialog();
        }

        private void btnType_product_Click(object sender, EventArgs e)
        {
            _Logger.Logging("Open table: " + ((Button)sender).Text);
            MessageBox.Show(_Logger.getLog());
            type_product.ShowDialog();
        }

        private Dictionary<string, string> TablesQueries = new Dictionary<string, string>()
        {
            {
                "Items",
                @"create table Items (
                    ID smallint primary key,
                    Name varchar(100) not null,
                    Cost float not null
                )"
            },
            {
                "additional_items",
                @"create table additional_items (
                    ID_product tinyint not null,
                    ID_Items smallint not null,
                    Number tinyint not null,
                    Description text,
                    primary key (ID_product, ID_Items)
                )"
            },
            {
                "List_product",
                @"create table List_product (
                    ID smallint primary key,
                    Name varchar(100) not null,
                    Main_component varchar(100) not null,
                    Cost float not null,
                    Product_weight float not null,
                        Product_type tinyint not null
                )"
            },
            {
                "Type_product",
                @"create table Type_product (
                    ID tinyint primary key,
                    Name varchar(40) not null,
                    Description text
                )"
            },
            {
                "Target_user",
                @"create table Target_user (
                    ID tinyint primary key,
                    Name varchar(50)
                )"
            },
            {
                "Product_package",
                @"create table Product_package (
                    ID tinyint primary key,    
                    List_product smallint not null,
                    Picker varchar(100) not null,
                    Target_user tinyint not null,
                    Date_ date,
                    Cost float not null,
                    Product_weight float not null,
                    Description_product text
                )"
            }
        };

        private Dictionary<string, string> FKTablesQueries = new Dictionary<string, string>()
        {
            {
                "FK__additional__items_Product__package",
                @"ALTER TABLE additional_items
	                add constraint FK__additional__items_Product__package foreign key (ID_product) references Product_package(ID)"
            },
            {
                "FK__additional__items__Items",
                @"ALTER TABLE additional_items
	                add constraint FK__additional__items__Items foreign key (ID_Items) references Items(ID)"
            },
            {
                "FK__List_product__Type_product",
                @"ALTER TABLE List_product
	                add constraint FK__List_product__Type_product foreign key (Product_type) references Type_product(ID)"
            },
            {
                "FK__Product_package__List_product",
                @"ALTER TABLE Product_package
	                add constraint FK__Product_package__List_product foreign key (List_product) references List_product(ID)"
            },
            {
                "FK__Product_package__Target_user",
                @"ALTER TABLE Product_package
	                add constraint FK__Product_package__Target_user foreign key (Target_user) references Target_user(ID)"
            }
        };

        private Dictionary<string, string> FKDROPTablesQueries = new Dictionary<string, string>()
        {
            {
                "FK__additional__items_Product__package",
                @"ALTER TABLE additional_items 
                    DROP FOREIGN KEY  FK__additional__items_Product__package;"
            },
            {
                "FK__additional__items__Items",
                @"ALTER TABLE additional_items 
                    DROP FOREIGN KEY FK__additional__items__Items;"
            },
            {
                "FK__List_product__Type_product",
                @"ALTER TABLE List_product 
                    DROP FOREIGN KEY FK__List_product__Type_product;"
            },
            {
                "FK__Product_package__List_product",
                @"ALTER TABLE Product_package 
                    DROP FOREIGN KEY FK__Product_package__List_product;"
            },
            {
                "FK__Product_package__Target_user",
                @"ALTER TABLE Product_package 
                    DROP FOREIGN KEY FK__Product_package__Target_user;"
            }
        };

        private void btnAllCreateTable_Click(object sender, EventArgs e)
        {
            dbmanager.ConnectMy();
            try
            {
                foreach (var query in TablesQueries.Values)
                {
                    dbmanager.ExecMySQL(query);
                }
            }
            catch
            {
                MessageBox.Show("Таблиці вже створено!");
            }
            dbmanager.DisconnectMy();
        }

        private void btnAllDropTable_Click(object sender, EventArgs e)
        {
            dbmanager.ConnectMy();
            try
            {
                foreach (var tableName in TablesQueries.Keys)
                {
                    string query = $"DROP TABLE {tableName}";
                    dbmanager.ExecMySQL(query);
                }
            }
            catch
            {
                MessageBox.Show("Потрібно видалити звязки!");
            }
            dbmanager.DisconnectMy();
        }

        private void btnAllCreateConstraint_Click(object sender, EventArgs e)
        {
            dbmanager.ConnectMy();
            try
            {
                foreach (var query in FKTablesQueries.Values)
                {
                    dbmanager.ExecMySQL(query);
                }
            }
            catch
            {
                MessageBox.Show("Зв'язок вже створено!");
            }
            dbmanager.DisconnectMy();
        }

        private void btnAllDropConstraint_Click(object sender, EventArgs e)
        {
            dbmanager.ConnectMy();
            foreach (var query in FKDROPTablesQueries.Values)
            {
                dbmanager.ExecMySQL(query);
            }
            dbmanager.DisconnectMy();
        }
    }
}