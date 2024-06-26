﻿using Common;
using Domain;
using Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class LoginForm : Form
    {
        #region -> Definición de Campos

        private DragControl dragControl;//Permite arrastrar el formulario
        private string usernamePlaceholder;//Marca de agua(Placeholder) para el cuadro de texto usuario.
        private string passwordPlaceholder;//Marca de agua(Placeholder) para el cuadro de texto contraseña.
        private Color placeholderColor;//Color del marca de agua(Placeholder).
        private Color textColor;//Color para el texto del cuadro texto.
        #endregion

        #region -> Constructor

        public LoginForm()
        {
            InitializeComponent();
            dragControl = new DragControl(this, this);//Inicializar el control de arrastre.
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;//Quitar borde del formulario.

            usernamePlaceholder = txtUsername.Text;//Establecer placeholder del cuadro de texto usuario.
            passwordPlaceholder = txtPassword.Text;//Establecer placeholder del cuadro de texto contraseña.
            placeholderColor = txtUsername.ForeColor;////Establecer color de placeholder.
            textColor = Color.Gainsboro;//Establecer color del cuadro de texto usuario y contraseña.

            label1.Select();//Seleccionar un control diferente, para que los cuadros de texto no se inicien enfocados.
        }
        #endregion

        #region -> Definición de Métodos

        private void SetPlaceholder()
        {//Establecer la marca de agua (Placeholder) al cuadro de texto usuario y contraseña,
            //Siempre en cuando el valor sea nulo o tiene espacios en blanco.
            if (string.IsNullOrWhiteSpace(txtUsername.Text))//Usuario
            {
                txtUsername.Text = usernamePlaceholder;
                txtUsername.ForeColor = placeholderColor;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))//Contraseña
            {
                txtPassword.Text = passwordPlaceholder;
                txtPassword.ForeColor = placeholderColor;
                txtPassword.UseSystemPasswordChar = false;//Quitar el enmascaramiento de caracteres.
            }
        }
        private void RemovePlaceHolder(TextBox textBox, string placeholderText)
        {//Quitar la marca de agua (Placeholder) de un cuadro de texto.
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";//Quitar placeholder
                textBox.ForeColor = textColor;//Establecer color normal de texto
                if (textBox == txtPassword)//Si el cuadro de texto es contraseña, enmascarar los caracteres.
                    textBox.UseSystemPasswordChar = true;

            }
        }
        private void Login()
        {//Iniciar sesión

            //Validar campos
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || txtUsername.Text == usernamePlaceholder)
            {
                ShowMessage("Ingrese nombre de usuario o correo electrónico");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text == passwordPlaceholder)
            {
                ShowMessage("Ingrese contraseña");
                return;
            }
            //Fin Validar campos

            //Ejecutar el metodo de inicio de sesión del modelo de dominio.
            var userModel = new UserModel().Login(txtUsername.Text, txtPassword.Text);//Devuelve un objeto UserModel como resultado.
            if (userModel != null)//Si el inicio de sesión fue exitosa.
            {
                /*Nota: Esto es solamente un ejemplo de demostración, ya que si el sistema es demasiado grande, 
                 * se suele mostrar un formulario de menu principal diferente para cada area o cargo.
                 * Puedes eliminar las condicionales y mostrar un formulario único*/

                Form mainForm;//Definir el campo para el formulario principal.

                if (ActiveUser.Position == Positions.Director || ActiveUser.Position == Positions.Secretaria)
                {
                    //Enviar el modelo de vista del usuario conectado, para mostrar sus datos en el formulario principal. 
                    mainForm = new MainForm(userModel);
                }
               
                else
                {
                    mainForm = null;
                    MessageBox.Show("Usted no tiene un cargo asignado, no puede iniciar sesión.", "Mensaje",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                this.Hide();//Ocultar el formualario login.
                var welcomeForm = new WelcomeForm(userModel.FullName);//Mostrar el formulario de bienvenida.
                welcomeForm.ShowDialog();
                mainForm.FormClosed += new FormClosedEventHandler(MainForm_SessionClosed);//Asociar el evento cerrado, para limpiar el formulario login cuando se cierre sesion desde el formulario principal.
                mainForm.Show();//Mostrar el formulario principal.
            }
            else //Si el inicio de sesión NO fue exitosa, mostrar mensaje.
                ShowMessage("Usuario o contraseña incorrecto");

        }
        private void Logout()
        {//Limpiar campos cuando se cierre sesión, este metodo se invoca en el metodo de evento MainForm_SessionClosed(..).
            this.Show();//Volver a mostrar el formulario login.
            txtUsername.Clear();
            txtPassword.Clear();
            SetPlaceholder();         
            label1.Select();
            lblErrorMessage.Visible = false;
        }
        private void ShowMessage(string message)
        {
            lblErrorMessage.Text = "    " + message;
            lblErrorMessage.Visible = true;
        }
        #endregion

        #region -> Definición de Métodos de Evento

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login();
        }
        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Login();
        }
        private void MainForm_SessionClosed(object sender, FormClosedEventArgs e)
        {
            Logout();
        }

        private void LoginForm_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.Gray, 1), txtPassword.Location.X, txtPassword.Bottom + 5, txtPassword.Right, txtPassword.Bottom + 5);
            e.Graphics.DrawLine(new Pen(Color.Gray, 1), txtUsername.Location.X, txtUsername.Bottom + 5, txtUsername.Right, txtUsername.Bottom + 5);
            e.Graphics.DrawRectangle(new Pen(Color.Gray), 0, 0, this.Width - 1, this.Height - 1);
        }     

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtUsername, usernamePlaceholder);
        }
        private void txtUsername_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }
        private void txtPassword_Enter(object sender, EventArgs e)
        {
            RemovePlaceHolder(txtPassword, passwordPlaceholder);
        }
        private void txtPassword_Leave(object sender, EventArgs e)
        {
            SetPlaceholder();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void lblForgotPass_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Por favor, contacte con el soporte con el número de tel: 2227-3900 para recuperar su contraseña. ");
        }
        #endregion

        #region -> Anulaciones

        protected override CreateParams CreateParams
        {//Anular los parámetros de creación de formularios
            get
            {
                CreateParams param = base.CreateParams;
                param.Style |= 0x20000; //Establece un cuadro de minimizar en el estilo de la ventana / Permitirá minimizar el formulario desde el icono de la barra de tareas
                return param;
            }
        }
        #endregion

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
