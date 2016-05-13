using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace Agenda_Rework
{
    public partial class WriteStuff : MetroForm
    {
        public int posSch = 1, posSelf = 1, posRe = 1, posWa = 1, posApp = 1, posTodo = 1;
        
        public WriteStuff()
        {
            InitializeComponent();
        }

        private void WriteStuff_Load(object sender, EventArgs e)
        {

        }

           public void reciveCheck(int value)
        {

        }
        private void writeA_click(object sender, EventArgs e)
        {
            // deleting if the default text still exist
            if (writeA.Text == "Add a to-do in unvirsity and school.." ||
                writeA.Text == "Add a to-do in self study.."||
                writeA.Text ==  "Add a to-do in to-read.." ||
                writeA.Text ==  "Add a to-do in to-watch.."||
                writeA.Text == "Add a to-do in appoiments..")     
            {
                writeA.Clear();
            }
        }

      
        private void Add_Click(object sender, EventArgs e)
        {
    
              if (writeA.Text == "" ||
                writeA.Text == "Add a to-do in unvirsity and school.." ||
                writeA.Text == "Add a to-do in self study.."||
                writeA.Text ==  "Add a to-do in to-read.." ||
                writeA.Text ==  "Add a to-do in to-watch.."||
                writeA.Text == "Add a to-do in appoiments..")   
              {
                  MessageBox.Show("Please write a TO-DO first!");
              }
              else
              {
                  string AllTodo = gendre.Text + ": " + writeA.Text;
                  Label lb = new Label();
                  Point p;
                  if (labelOf.Text == "University/School")  p = new Point (0, 30 * posSch);
                  else if (labelOf.Text == "Self Study") p = new Point(0, 30 * posSelf);
                  else if (labelOf.Text == "To Read") p = new Point(0, 30 * posRe);
                  else if (labelOf.Text == "To Watch") p = new Point(0, 30 * posWa);
                  else p = new Point(0, 30 * posApp);
                  lb.Location = p;
                  lb.Size = new Size(1000, 20);
                  lb.Text = AllTodo;
                  lb.ForeColor = System.Drawing.Color.Gray;
                  finalto.Controls.Add(lb);
                  if (labelOf.Text == "University/School")
                  {
                      writeA.Text = "Add a to-do in unvirsity and school..";
                      gendre.SelectedIndex = 4;
                      posSch++;
                      Add0(AllTodo);
                  }
                  else if (labelOf.Text == "Self Study")
                  {
                      writeA.Text = "Add a to-do in self study..";
                      gendre.SelectedIndex = 5;
                      posSelf++;
                      Add1(AllTodo);
                  }
                  else if (labelOf.Text == "To Read")
                  {
                      writeA.Text = "Add a to-do in to-read..";
                      gendre.SelectedIndex = 7;
                      posRe++;
                      Add2(AllTodo);
                  }

                  else if (labelOf.Text == "To Watch")
                  {
                      writeA.Text = "Add a to-do in to-watch..";
                      gendre.SelectedIndex = 6;
                      posWa++;
                      Add3(AllTodo); 
                  }
                  else
                  {
                      gendre.SelectedIndex = 4;
                      writeA.Text = "Add a to-do in appoiments..";
                      posApp++;
                      Add4(AllTodo);
                  }
              }
        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        public string LabelText
        {  // start of get and set of the label to access the label from another form(main form)
            get
            {
                return this.labelOf.Text;
            }
            set
            {
                this.labelOf.Text = value;
            }
        }  

        public string TodowriteText
        {  // start of get and set of the label to access the textboxx from another form(main form)
            get
            {
                return this.writeA.Text;
            }
            set
            {
                this.writeA.Text = value;
            }
        } 
       
        /*
         *  here iam gonna start building the database of the todos and how should i show it
         * the add button function will call each of them depends on what the user had clicked on
         */
              public void Add0(string todo)
               {
                   // school\uni database  ((0))

                   FileStream writescho = new FileStream("school.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter force = new StreamWriter(writescho);
                   FileStream wetodo = new FileStream("todo.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter lightsaber = new StreamWriter(wetodo);
                   force.WriteLine(todo);
                   lightsaber.WriteLine("#University/School " + todo);
                   lightsaber.Close();
                   wetodo.Close();
                   force.Close();
                   writescho.Close();
                   
                  }
                    
              public void Add1(string todo)
               {
                   // selfstudy data base   ((1))
                   FileStream writeself = new FileStream("selfstudy.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter force = new StreamWriter(writeself);
                   FileStream wetodo = new FileStream("todo.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter lightsaber = new StreamWriter(wetodo);
                   force.WriteLine(todo);
                   lightsaber.WriteLine("#Self Study " + todo);
                   lightsaber.Close();
                   wetodo.Close();
                   force.Close();
                   writeself.Close();
                 
               }
               public void Add2(string todo)
               {
                  // toread data base  ((2))
                   FileStream writere = new FileStream("toread.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter force = new StreamWriter(writere);
                   FileStream wetodo = new FileStream("todo.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter lightsaber = new StreamWriter(wetodo);
                   force.WriteLine(todo);
                   lightsaber.WriteLine("#To Read " + todo);
                   lightsaber.Close();
                   wetodo.Close();
                   force.Close();
                   writere.Close();
                  
               }
               public void Add3(string todo)
               {
                  // towatch database    ((3))
                   FileStream writewa = new FileStream("towatch.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter force = new StreamWriter(writewa);
                   FileStream wetodo = new FileStream("todo.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter lightsaber = new StreamWriter(wetodo);
                   force.WriteLine(todo);
                   lightsaber.WriteLine("#To Watch " + todo);
                   lightsaber.Close();
                   wetodo.Close();
                   force.Close();
                   writewa.Close();
                 
               }
               public void Add4(string todo)
               {
                  //  appoiments datbase   ((4))
                   FileStream writeapp = new FileStream("appoiments.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter force = new StreamWriter(writeapp);
                   FileStream wetodo = new FileStream("todo.txt", FileMode.Append, FileAccess.Write);
                   StreamWriter lightsaber = new StreamWriter(wetodo);
                   force.WriteLine(todo);
                   lightsaber.WriteLine("#Appointments " + todo);
                   lightsaber.Close();
                   wetodo.Close();
                   force.Close();
                   writeapp.Close();
                 
               }

              
               private void deletechecked_Click(object sender, EventArgs e)
               {
                   List<CheckBox> itemsToRemoveSe = new List<CheckBox>();
                   List<CheckBox> itemsToRemoveUn = new List<CheckBox>();
                   List<CheckBox> itemsToRemoveRe = new List<CheckBox>();
                   List<CheckBox> itemsToRemoveWa = new List<CheckBox>();
                   List<CheckBox> itemsToRemoveApp = new List<CheckBox>();
                   List<CheckBox> itemsToRemoveTodo = new List<CheckBox>();
                   List<CheckBox> itemsToAdd = new List<CheckBox>();
                   List<CheckBox> allItemsToRemove = new List<CheckBox>();
                   foreach (Control ctrll in todoPanel.Controls)
                   {
                       CheckBox checkBox = ctrll as CheckBox;
                       if (checkBox != null)   // Control is a CheckBox
                       {
                           if (!checkBox.Checked)
                           {
                               itemsToAdd.Add(checkBox);
                           }
                           //  knowing from which exactly file i will delete so i will put it in its own list
                           if (checkBox.Checked)
                           {
                               itemsToRemoveTodo.Add(checkBox);
                               string temp = checkBox.Text; 
                                // self study
                               if(temp[1]=='S')
                                 {
                                     itemsToRemoveSe.Add(checkBox);
                                 }
                                // uni and school 
                               else if (temp[1] == 'U')
                                 {
                                     itemsToRemoveUn.Add(checkBox);
                                 }
                               // appoiments 
                               else if (temp[1] == 'A')
                                 {
                                     itemsToRemoveApp.Add(checkBox);
                                 }
                               // to read
                               else if (temp[4] == 'R')
                               {
                                   itemsToRemoveRe.Add(checkBox);
                               }
                               // to watch
                               else if (temp[4] == 'W')
                               {
                                   itemsToRemoveWa.Add(checkBox);
                               }
                           }

                           allItemsToRemove.Add(checkBox);
                       }
                   }
                   // removing everything
                   foreach (CheckBox chh in allItemsToRemove)
                   {
                       posTodo = 1;
                       todoPanel.Controls.Remove(chh);
                       chh.Dispose();
                   }
                   // adding all the uncheck
                   foreach (CheckBox checkboxadd in itemsToAdd)
                   {
                       CheckBox ch = new CheckBox();
                       Point p = new Point(0, 50 * posTodo);
                       ch.Location = p;
                       ch.Size = new Size(1000, 20);
                       ch.Text = checkboxadd.Text;
                       ch.ForeColor = System.Drawing.Color.Gray;
                       todoPanel.Controls.Add(ch);
                       posTodo++;

                   }
                 //deleting from the files itself( calling the method)
                   deleteFiles(itemsToRemoveTodo, "todo.txt");
                   if (itemsToRemoveApp.Count>0) deleteFiles(itemsToRemoveApp, "appoiments.txt");
                   if(itemsToRemoveRe.Count>0) deleteFiles(itemsToRemoveRe, "toread.txt");
                   if(itemsToRemoveSe.Count>0) deleteFiles(itemsToRemoveSe, "selfstudy.txt");
                   if(itemsToRemoveUn.Count>0)deleteFiles(itemsToRemoveUn, "school.txt");
                   if(itemsToRemoveWa.Count>0)deleteFiles(itemsToRemoveWa, "towatch.txt");
                 
               }
               
                 // method deleting from the files
               public void deleteFiles(List<CheckBox> remove, string pathName)
               {
                   // replacing all the lines i wanna delete with *;
                   foreach (CheckBox checkboxre in remove)
                   {
                       string temp = checkboxre.Text;
                       
                       if (pathName == "school.txt")temp= temp.Remove(0, 19);
                       else if (pathName == "selfstudy.txt")temp= temp.Remove(0, 12);
                       else if (pathName == "toread.txt") temp=temp.Remove(0, 9);
                       else if (pathName == "towatch.txt")temp= temp.Remove(0, 10);
                       else if (pathName == "appoiments.txt")temp= temp.Remove(0, 14);
                       
                       string text = File.ReadAllText(pathName);
                       text = text.Replace(temp, "*");
                       File.WriteAllText(pathName, text);
                   }     
                // moving the data to another temp files so i can delete the *
                   FileStream tempFi = new FileStream("temp.txt", FileMode.Create, FileAccess.Write);
                   StreamWriter tempWrite = new StreamWriter(tempFi);
                   FileStream sourFi = new FileStream(pathName, FileMode.Open, FileAccess.Read);
                   StreamReader sourRead = new StreamReader(sourFi);
                   string line = "";
                   while((line=sourRead.ReadLine())!= null)
                   {
                       if (line != "*")
                       {
                           tempWrite.WriteLine(line);
                       }
                   }
                   tempWrite.Close();
                   tempFi.Close();
                   sourRead.Close();
                   sourFi.Close();

                   // returning all the data to the source file
                   System.IO.File.WriteAllText(pathName, string.Empty);
                   FileStream sourFi2 = new FileStream(pathName, FileMode.Open, FileAccess.Write);
                   StreamWriter sourWrite = new StreamWriter(sourFi2);
                   FileStream tempFi2 = new FileStream("temp.txt", FileMode.Open, FileAccess.Read);
                   StreamReader tempRead = new StreamReader(tempFi2);
                   while ((line = tempRead.ReadLine()) != null)
                   {
                       sourWrite.WriteLine(line);
                   }
                   sourWrite.Close();
                   sourFi2.Close();
                   tempRead.Close();
                   tempFi2.Close();
                   File.Delete("temp.txt");
               }
           
        
               private void finalto_Paint(object sender, PaintEventArgs e)
               {

               }

               private void metroPanel2_Paint(object sender, PaintEventArgs e)
               {

               }

               private void metroPanel1_Paint(object sender, PaintEventArgs e)
               {

               }

    
    }
}
