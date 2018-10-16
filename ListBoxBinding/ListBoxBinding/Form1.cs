using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ListBoxBinding
{
public partial class Form1 : Form
{
  public Form1()
  {
    InitializeComponent();
  }

  private void Form1_Load(object sender, EventArgs e)
  {
    Person[] People = new Person[] {
              new Person("John","Smith"),
              new Person("Jane" ,"Doe")};
    lstPersons.DataSource = People;
    //lstPersons.DisplayMember = "FirstName";
  }
}


public struct Person
{
  private string firstName, lastName;
  
  public Person(string firstName, string lastName)
  {
    this.firstName = firstName;
    this.lastName = lastName;
  }
  
  public string FirstName 
  { 
    get 
    { 
      return firstName; 
    } 
  }
  
  public string LastName 
  { 
    get 
    { 
      return lastName; 
    } 
  }
}
}