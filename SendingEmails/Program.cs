﻿using System;
using System.Net;
using System.Net.Mail;

namespace SendingEmails
{
    class Program
    {
        public static void Main(string[] args)
        {
            MailAddress to = new MailAddress("dmwimbley0606@gmail.com");
            MailAddress from = new MailAddress("VincentL921@gmail.com");

            MailMessage email = new MailMessage(from, to);
            email.Subject = "Testing Out Email Sending";
            email.Body = "What's gucci bro.";

            System.Net.Mail.Attachment attachment;
            attachment = new Attachment("https://youtu.be/bHW7JkHWtf4");
            email.Attachments.Add(attachment);

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.Credentials = new NetworkCredential("l34rn2c0d3g00d@gmail.com", "pablzyzvvhybodrd");
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.EnableSsl = true;

            smtp.Send(email);

            //try
            //{
            //    smtp.Send(email);
            //}
            //catch (SmtpException ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}
        }
    }
}

