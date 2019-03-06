using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using Microsoft.Office.Interop.Excel;
using _Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace longitude_and_latitude
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        string path = "", new_path = "";
        _Application excel = new _Excel.Application();
        Workbook wb;
        Worksheet ws;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_open_xlsx_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Выберите excel-файл";
            ofd.Filter = "Excel Files|*.xls;*.xlsx";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                path = ofd.FileName;
            }
            else return;
        }

        private void button_save_xlsx_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите директорию сохранения excel-файла";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                new_path = fbd.SelectedPath;
            }
            else return;
        }

        private void button_year_by_address_Click(object sender, EventArgs e)
        {
            if (path == "")
            {
                MessageBox.Show("Выберите excel-файл");
                return;
            }

            if (new_path == "")
            {
                MessageBox.Show("Выберите директорию для сохранения");
                return;
            }

            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];

            //сколько строк дано
            int data_i = 2;
            while (ws.Cells[data_i, 19].Value2 != null)
            { data_i++; }
            data_i -= 2;

            //открытие браузера
            string url_site_map = "http://" + "dom.mingkh.ru/search?address=%D0%95%D0%BA%D0%B0%D1%82%D0%B5%D1%80%D0%B8%D0%BD%D0%B1%D1%83%D1%80%D0%B3%2C+" + "" +
                "%D0%91%D0%B5%D0%B1%D0%B5%D0%BB%D1%8F%2C+117&searchtype=house";
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl(url_site_map);
            Thread.Sleep(3000);

            IWebElement adress_element, data_element;
            adress_element = Browser.FindElement(By.Id("address"));


            //сбор данных
            for (int i = 2; i <= data_i + 1; i++)
            {
                string adress_i = ws.Cells[i, 19].Value2;
                adress_element.SendKeys(OpenQA.Selenium.Keys.Control + "a" + OpenQA.Selenium.Keys.Delete);
                adress_element.SendKeys("Екатеринбург, " + adress_i + OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(3000);

                //координат может быть не дано
                try
                {
                    //List<IWebElement> addressList;
                    //addressList = Browser.FindElements(By.CssSelector(".c6e8ba5398-header--1_m0_")).ToList();

                    //data_element = Browser.FindElement(By.ClassName("clipboard__content"));
                    //string data_str = data_element.Text;
                    //string shirota = data_str.Substring(0, data_str.Length - 11);
                    //string dolgota = data_str.Substring(data_str.Length - 9, 9);

                    //ws.Cells[i, 5].Value2 = shirota;
                    //ws.Cells[i, 6].Value2 = dolgota;
                }
                catch { }


                textBox_year.Text = (i - 1).ToString() + "/" + data_i;
            }


        }

        private void button_start_Click(object sender, EventArgs e)
        {

            if (path == "")
            {
                MessageBox.Show("Выберите excel-файл");
                return;
            }

            if (new_path == "")
            {
                MessageBox.Show("Выберите директорию для сохранения");
                return;
            }

            button_start.Enabled = false;
            button_open_xlsx.Enabled = false;
            button_save_xlsx.Enabled = false;
            //открытие excel
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[1];

            //сколько строк дано
            int data_i = 2;
            while (ws.Cells[data_i, 21].Value2 != null)
            { data_i++; }
            data_i -= 2;

            //открытие браузера
                    //string url_site_map_api = "https://" + "yandex.ru/map-constructor/location-tool/";

            string url_site_map = "http://" + "yandex.ru/maps";
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            //Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl(url_site_map);
                    //Browser.Navigate().GoToUrl(url_site_map_api);
            
            Thread.Sleep(3000);

            IWebElement adress_element, data_element;
                        //button_element_continue, button_element_search;
            //button_element_continue = Browser.FindElement(By.LinkText("Продолжить"));
            //button_element_continue.Click();

            adress_element = Browser.FindElement(By.ClassName("input_air-search-large__control"));

            //сбор данных
                                //data_i + 1
            for (int i = 2; i <= data_i + 1; i++)
            {
                //button_element_search = Browser.FindElement(By.ClassName("ymaps-2-1-72-searchbox"));
                //button_element_search.Click();

                //adress_element = Browser.FindElement(By.ClassName("ymaps-2-1-72-searchbox-input__input"));

                string adress_i = ws.Cells[i, 21].Value2;
                adress_element.SendKeys(OpenQA.Selenium.Keys.Control + "a" + OpenQA.Selenium.Keys.Delete);
                adress_element.SendKeys(adress_i + OpenQA.Selenium.Keys.Enter);
                Thread.Sleep(3000);
                
                //координат может быть не дано
                try
                {
                    //data_element = Browser.FindElement(By.Id("markerCenter"));

                    data_element = Browser.FindElement(By.ClassName("clipboard__content"));
                    string data_str = data_element.Text;
                    
                    string shirota = data_str.Substring(0, data_str.Length - 11);
                    string dolgota = data_str.Substring(data_str.Length - 9, 9);

                            //string shirota = data_str.Substring(0, data_str.Length - 19);
                            //string dolgota = data_str.Substring(data_str.Length - 17, 17);
                    ws.Cells[i, 5].Value2 = shirota;
                    ws.Cells[i, 6].Value2 = dolgota;
                }
                catch { }

                
                textBox1.Text = (i - 1).ToString() + "/" + data_i;
            }
            
            new_path += @"\" + DateTime.Now.ToString().Replace('/', '-').Replace(':', '-') + "_шир_и_долг.xlsx";

            
            wb.SaveAs(new_path);
            wb.Close();

            Browser.Quit();
            Browser = null;
            button_start.Enabled = true;
            button_open_xlsx.Enabled = true;
            button_save_xlsx.Enabled = true;

        }

    }
}
