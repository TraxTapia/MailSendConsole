using System;
using System.Net.Mail;


namespace sendMail
{
    class Program
    {
        static void Main(string[] args)
        {

            //senMailMediaccess();
            //Console.WriteLine("Ingresa una direccion de correo electronico");
            //string para;
            //para = Console.ReadLine();
            //Console.WriteLine("Ingresa un cuerpo de mensaje");
            //string body;
            //body = Console.ReadLine();
            //Console.WriteLine("El texto introducido es: " + texto);
            //Console.WriteLine("Ingresa una direccion de correo electronico")
            //string para;
            //string body;


            ////sendMail("traxtapia1227@gmail.com", "hola esta es una prueba");
            //senMailMediaccessContacto();
            mailContacto();
            //sendMail(para, "testtapia1227@gmail.com", body);
            ////Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        public static string htmlBody(string titulo, string nombre, string direccion, string correo, string num_tel, string area, string mensaje)
        {
            string cuerpo_html = "";
            cuerpo_html = "<html><body  style='font-family: Helvetica, Arial, sans-serif; font-size: 14px;'><br><table width='90%' border='0'>";

            cuerpo_html += "<tr><td colspan='2' align='left' ><b>" + titulo + "</b></td></tr><tr><td></td></tr>";

            cuerpo_html += "<tr><td align='left' width='30%'>Nombre:</td><td> <b>" + nombre + "</b></td> </tr>";

            cuerpo_html += "<tr><td align='left' width='30%'>Direcci&oacute;n:</td><td> <b>" + direccion + "</b></td> </tr>";

            cuerpo_html += "<tr><td align='left' width='30%'>Mail:</td><td> <b>" + correo + "</b></td> </tr>";

            cuerpo_html += "<tr><td align='left' width='30%'>N&uacute;mero Tel&eacute;fono:</td><td> <b>" + num_tel + "</b></td> </tr>";

            cuerpo_html += "<tr><td align='left' width='30%'>&Aacute;rea:</td><td> <b>" + area + "</b></td> </tr>";

            cuerpo_html += "<tr><td align='left' width='30%'>Mensaje:</td><td align='justify' > <b>" + mensaje + "</b></td> </tr>";

            cuerpo_html += "</table><br> <b>Favor de Contactar.</b><br></body></html>";


            return cuerpo_html;
        }
        public static void senMailMediaccessContacto()
        {
            try
            {
                string body_html = "";
                body_html = htmlBody("Aviso de Bolsa de Trabajo", "IVAN", "PRUEBA", "traxtapia1227@gmail.com", "030330303", "SISTEMAS", "PRUEBA");

                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress("traxtapia1227@gmail.com"));
                email.From = new MailAddress("notificaciones@mediaccess.com.mx");
                email.Subject = "Contacto Mediaccess";
                email.Body = body_html;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();

                smtp.Host = "SMTP.Office365.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("notificaciones@mediaccess.com.mx", "Mak28596");



                smtp.Send(email);


                Console.WriteLine("*****---Mensaje enviado con exito---*****");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ocurrio un error " + ex.Message);

            }



        }
        public static void senMailMediaccess()
        {
            try
            {
                string body_html = "";
                body_html = htmlBody("Aviso de Bolsa de Trabajo", "IVAN", "PRUEBA", "traxtapia1227@gmail.com", "030330303", "SISTEMAS", "PRUEBA");

                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress("ventas@mediaccess.com.mx"));
                email.From = new MailAddress("nnotificaciones@mediaccess.com.mx");
                email.Subject = "Contacto Mediaccess";
                email.Body = body_html;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();

                smtp.Host = "SMTP.Office365.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("notificaciones@mediaccess.com.mx", "Mak28596");



                smtp.Send(email);


                Console.WriteLine("*****---Mensaje enviado con exito---*****");

            }
            catch (Exception ex )
            {
                Console.WriteLine("ocurrio un error " + ex.Message);
               
            }
          


        }
        public static void sendMail(string email,string cc, string body)
        {
         

            if (String.IsNullOrEmpty(email))
                return;
            try
            {
                MailMessage mail = new MailMessage();
                mail.To.Add(email);
                mail.CC.Add(string.Join(",", cc));
                mail.From = new MailAddress("testtapia1227@gmail.com");
                mail.Subject = "sub";

                mail.Body = body;

                mail.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com"; //Or Your SMTP Server Address
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("testtapia1227@gmail.com", "admin@1234"); // ***use valid credentials***
                smtp.Port = 587;

                //Or your Smtp Email ID and Password
                smtp.EnableSsl = true;
                smtp.Send(mail);

                Console.WriteLine("*****Mensaje enviado con exito****");
            }
            catch (Exception ex)
            {
                Console.WriteLine("ocurrio un error " + ex.Message);
            }
        }
        
     public static void mailContacto()
        {
            try
            {
                string body_html = "";
                body_html = htmlBody("Aviso de Bolsa de Trabajo", "IVAN", "PRUEBA", "traxtapia1227@gmail.com", "030330303", "SISTEMAS", "PRUEBA");

                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress("ventas@mediaccess.com.mx"));
                email.From = new MailAddress("notificaciones@mediaccess.com.mx");
                email.Subject = "Contacto Mediaccess";
                email.Body = body_html;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.High;
                SmtpClient smtp = new SmtpClient();

                smtp.Host = "SMTP.Office365.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential("notificaciones@mediaccess.com.mx", "Mak28596");



                smtp.Send(email);


                Console.WriteLine("*****---Mensaje enviado con exito---*****");

            }
            catch (Exception ex)
            {
                Console.WriteLine("ocurrio un error " + ex.Message);

            }
        }
    }
}
