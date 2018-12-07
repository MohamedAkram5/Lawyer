using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lawyer_2.Models.ViewModel
{
    public class TypeViewModel
    {
        public int Id { get; set; }
        public List<SelectListItem> Types = new List<SelectListItem>();
    }

    public class TelephoneViewModel
    {
        public string Phone { get; set; }
    }

    public class AddressViewModel
    {
        public string Country { get; set; }
        public string PostalCode { get; set; }
        public string Region { get; set; }
        public string Street { get; set; }
        public string Street2 { get; set; }
        public int City { get; set; }
        public List<SelectListItem> Cities = new List<SelectListItem>();
    }

    public class EduQualViewModel
    {
        public DateTime QualDate { get; set; }
        public string QualDesc { get; set; }
        public int Degree { get; set; }
        public int University { get; set; }
        public int College { get; set; }
        public int QualType { get; set; }
    }

    public class EduQualPartialViewModel
    {
        public List<SelectListItem> Univeristies = new List<SelectListItem>();
        public List<SelectListItem> Colleges = new List<SelectListItem>();
        public List<SelectListItem> Degrees = new List<SelectListItem>();
        public List<SelectListItem> QualificationTypes = new List<SelectListItem>();
    }

    public class FirstRegisterViewModel
    {
        public List<SelectListItem> ProviderDegrees = new List<SelectListItem>();
        public List<SelectListItem> UserTypes = new List<SelectListItem>();
    }

    public class CertificationViewModel
    {
        public string Name { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public DateTime ExpDate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}