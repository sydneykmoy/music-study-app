﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;


namespace StudyApp.Server.Models
{
    public class PixelaSignUpModel
    {
        public string Username {get;set;}
        public string Token { get; set; }
    }
}
