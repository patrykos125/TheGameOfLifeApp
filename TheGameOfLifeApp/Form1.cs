using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TheGameOfLifeApp
{
    public partial class Form1 : Form
    {
        TheGameOfLifeService service;
         
        public Form1()
        {
            InitializeComponent();
            
        }


        private bool showNextEraOptions=false;


        private void plansza10x10ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service = new TheGameOfLifeService();

            service.setArray(new bool[10, 10]);
            drawGameBoard(10, 10);
            if (!showNextEraOptions) {  addNextEratToOptionsInMenu(); showNextEraOptions = true; }
                   
           
        }



        private void plansza10x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service = new TheGameOfLifeService();

            service.setArray(new bool[10, 15]);
            drawGameBoard(10, 15);
            if (!showNextEraOptions) { addNextEratToOptionsInMenu(); showNextEraOptions = true; }

        }
        private void plansza15x15ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            service = new TheGameOfLifeService();

            service.setArray(new bool[15, 15]); 
            drawGameBoard(15, 15);
            if (!showNextEraOptions) { addNextEratToOptionsInMenu(); showNextEraOptions = true; }
        }
        private void addNextEratToOptionsInMenu() {
            this.nextEraToolStripMenuItem.Name = "nextEraToolStripMenuItem";
            this.nextEraToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.nextEraToolStripMenuItem.Text = "Nowa Era";
            this.nextEraToolStripMenuItem.Click += new System.EventHandler(this.onClickNextEra);
        }
        private void drawGameBoard(int height, int width)
        {


            mainPanel.Controls.Clear();


            int panelWidth = mainPanel.Width;
            int panelHeight = mainPanel.Height;
            int size = panelWidth / width < panelHeight / height ? panelWidth / width : panelHeight / height;


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Button b = new Button();


                    b.Location = new Point(j * size, i * size);
                    b.Size = new Size(size, size);
                    b.BackColor = Color.White;
                    b.TabIndex = 0;
                    b.Click += new System.EventHandler(this.onClickButton);
                    b.Tag = new Point(i, j);

                    mainPanel.Controls.Add(b);
                }
            }


        }
        private void onClickButton(object sender, EventArgs e)
        {
            bool[,] array = service.getArray();

            Button b = (sender as Button);
            Point p = (Point)(b.Tag);
            if (b.BackColor == Color.White)
            {
                b.BackColor = Color.Green;
                array[p.X, p.Y] = true;
                
              
            }
            else
            {
                b.BackColor = Color.White;
                array[p.X, p.Y] = false;
            }
            //Console.WriteLine(p.X + " "+p.Y);

            service.setArray(array);
           





        }
        
        private  void onClickNextEra(object sender, EventArgs e)
        {



            bool[,] future = service.nextEra();
                drawNexEra(future);

                 service.setArray(future)  ; 

           




        }

        
        private void drawNexEra(bool[,] futureArray)
             {
            
            
       
                int height = futureArray.GetLength(0);
                int width = futureArray.GetLength(1);

                var items = mainPanel.Controls;



                for (int i = 0; i < height; i++)
                {

                    for (int j = 0; j < width; j++)
                    {


                        var item = items.Cast<Control>().FirstOrDefault(control => Equals((Point)control.Tag, new Point(i, j)));
                        item.BackColor = Color.Pink;


                        if (futureArray[i, j])
                        {
                            item.BackColor = Color.Green;
                        }
                        else { item.BackColor = Color.White; }

                    }


                
            }

            


        }

        private void onClickZapisz(object sender, EventArgs e) {

            JsonSerializerService jsonSerializerService = new JsonSerializerService();
            jsonSerializerService.savearrayAsJSON(service.getArray());


        }
        private void onClickWczytaj(object sender, EventArgs e)
        {
            addNextEratToOptionsInMenu();
            service = new TheGameOfLifeService();
            JsonSerializerService jsonSerializerService = new JsonSerializerService();

        bool[,] array =  jsonSerializerService.openJsonAsArray();
            drawGameBoard(array.GetLength(0), array.GetLength(1));
                service.setArray(array);
               drawNexEra(array);
            
           
            


        }
        
        }
}

    

