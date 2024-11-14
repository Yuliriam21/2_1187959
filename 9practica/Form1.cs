﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

using Newtonsoft.Json;
using System.Windows.Documents;

namespace _9practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main();
        }

        public class Geo
        {
            public string lat { get; set; }
            public string lng { get; set; }
        }

        public class Address
        {
            public string street { get; set; }
            public string suite { get; set; }
            public string city { get; set; }
            public string zipcode { get; set; }
            public Geo geo { get; set; }
        }

        public class Company
        {
            public string name { get; set; }
            public string catchPhrase { get; set; }
            public string bs { get; set; }
        }

        public class Usuario
        {
            public int id { get; set; }
            public string name { get; set; }
            public string username { get; set; }
            public string email { get; set; }
            public Address address { get; set; }
            public string phone { get; set; }
            public string website { get; set; }
            public Company company { get; set; }
        }

         async Task Main()
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/users";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {

                        string jsonContent = await response.Content.ReadAsStringAsync();
                        List<Usuario> usuarios =  JsonConvert.DeserializeObject<List<Usuario>>(jsonContent);

                        data.DataSource = usuarios;
                        
                        Console.WriteLine("Datos JSON obtenidos:");
                        Console.WriteLine(jsonContent);
                    }
                    else
                    {
                        Console.WriteLine("Error al realizar la solicitud. Código de estado: " + response.StatusCode);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}