using BusinessLayer.Concrete;
using CoreDemo.ViewModels;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        [HttpGet]
        public IActionResult Register()
        {
            List<CitiesViewModel> City = new List<CitiesViewModel>()
            {
                new CitiesViewModel{CityId=1, CityName="ADANA"},
                new CitiesViewModel{CityId=2, CityName="ADIYAMAN"},
                new CitiesViewModel{CityId=3, CityName="AFYONKARAHİSAR"},
                new CitiesViewModel{CityId=4, CityName="AĞRI"},
                new CitiesViewModel{CityId=5, CityName="AMASYA"},
                new CitiesViewModel{CityId=6, CityName="ANKARA"},
                new CitiesViewModel{CityId=7, CityName="ANTALYA"},
                new CitiesViewModel{CityId=8, CityName="ARTVİN"},
                new CitiesViewModel{CityId=9, CityName="AYDIN"},
                new CitiesViewModel{CityId=10, CityName="BALIKESİR"},
                new CitiesViewModel{CityId=11, CityName="BİLECİK"},
                new CitiesViewModel{CityId=12, CityName="BİNGÖL"},
                new CitiesViewModel{CityId=13, CityName="BİTLİS"},
                new CitiesViewModel{CityId=14, CityName="BOLU"},
                new CitiesViewModel{CityId=15, CityName="BURDUR"},
                new CitiesViewModel{CityId=16, CityName="BURSA"},
                new CitiesViewModel{CityId=17, CityName="ÇANAKKALE"},
                new CitiesViewModel{CityId=18, CityName="ÇANKIRI"},
                new CitiesViewModel{CityId=19, CityName="ÇORUM"},
                new CitiesViewModel{CityId=20, CityName="DENİZLİ"},
                new CitiesViewModel{CityId=21, CityName="DİYARBAKIR"},
                new CitiesViewModel{CityId=22, CityName="EDİRNE"},
                new CitiesViewModel{CityId=23, CityName="ELAZIĞ"},
                new CitiesViewModel{CityId=24, CityName="ERZİNCAN"},
                new CitiesViewModel{CityId=25, CityName="ERZURUM"},
                new CitiesViewModel{CityId=26, CityName="ESKİŞEHİR"},
                new CitiesViewModel{CityId=27, CityName="GAZİANTEP"},
                new CitiesViewModel{CityId=28, CityName="GİRESUN"},
                new CitiesViewModel{CityId=29, CityName="GÜMÜŞHANE"},
                new CitiesViewModel{CityId=30, CityName="HAKKARİ"},
                new CitiesViewModel{CityId=31, CityName="HATAY"},
                new CitiesViewModel{CityId=32, CityName="ISPARTA"},
                new CitiesViewModel{CityId=33, CityName="MERSİN"},
                new CitiesViewModel{CityId=34, CityName="İSTANBUL"},
                new CitiesViewModel{CityId=35, CityName="İZMİR"},
                new CitiesViewModel{CityId=36, CityName="KARS"},
                new CitiesViewModel{CityId=37, CityName="KASTAMONU"},
                new CitiesViewModel{CityId=38, CityName="KAYSERİ"},
                new CitiesViewModel{CityId=39, CityName="KIRKLARELİ"},
                new CitiesViewModel{CityId=40, CityName="KIRŞEHİR"},
                new CitiesViewModel{CityId=41, CityName="KOCAELİ"},
                new CitiesViewModel{CityId=42, CityName="KONYA"},
                new CitiesViewModel{CityId=43, CityName="KÜTAHYA"},
                new CitiesViewModel{CityId=44, CityName="MALATYA"},
                new CitiesViewModel{CityId=45, CityName="MANİSA"},
                new CitiesViewModel{CityId=46, CityName="KAHRAMANMARAŞ"},
                new CitiesViewModel{CityId=47, CityName="MARDİN"},
                new CitiesViewModel{CityId=48, CityName="MUĞLA"},
                new CitiesViewModel{CityId=49, CityName="MUŞ"},
                new CitiesViewModel{CityId=50, CityName="NEVŞEHİR"},
                new CitiesViewModel{CityId=51, CityName="NİĞDE"},
                new CitiesViewModel{CityId=52, CityName="ORDU"},
                new CitiesViewModel{CityId=53, CityName="RİZE"},
                new CitiesViewModel{CityId=54, CityName="SAKARYA"},
                new CitiesViewModel{CityId=55, CityName="SAMSUN"},
                new CitiesViewModel{CityId=56, CityName="SİİRT"},
                new CitiesViewModel{CityId=57, CityName="SİNOP"},
                new CitiesViewModel{CityId=58, CityName="SİVAS"},
                new CitiesViewModel{CityId=59, CityName="TEKİRDAĞ"},
                new CitiesViewModel{CityId=60, CityName="TOKAT"},
                new CitiesViewModel{CityId=61, CityName="TRABZON"},
                new CitiesViewModel{CityId=62, CityName="TUNCELİ"},
                new CitiesViewModel{CityId=63, CityName="ŞANLIURFA"},
                new CitiesViewModel{CityId=64, CityName="UŞAK"},
                new CitiesViewModel{CityId=65, CityName="VAN"},
                new CitiesViewModel{CityId=66, CityName="YOZGAT"},
                new CitiesViewModel{CityId=67, CityName="ZONGULDAK"},
                new CitiesViewModel{CityId=68, CityName="AKSARAY"},
                new CitiesViewModel{CityId=69, CityName="BAYBURT"},
                new CitiesViewModel{CityId=70, CityName="KARAMAN"},
                new CitiesViewModel{CityId=71, CityName="KIRIKKALE"},
                new CitiesViewModel{CityId=72, CityName="BATMAN"},
                new CitiesViewModel{CityId=73, CityName="ŞIRNAK"},
                new CitiesViewModel{CityId=74, CityName="BARTIN"},
                new CitiesViewModel{CityId=75, CityName="ARDAHAN"},
                new CitiesViewModel{CityId=76, CityName="IĞDIR"},
                new CitiesViewModel{CityId=77, CityName="YALOVA"},
                new CitiesViewModel{CityId=78, CityName="KARABÜK"},
                new CitiesViewModel{CityId=79, CityName="KİLİS"},
                new CitiesViewModel{CityId=80, CityName="OSMANİYE"},
                new CitiesViewModel{CityId=81, CityName="DÜZCE"},
            };
            return View(City);
        }

        [HttpPost]
        public IActionResult Register(Writer writer)
        {

            writer.WriterStatus = true;
            writer.WriterAbout = "Yazar hakkında";
            wm.AddWriter(writer);
            //var values = writer;
            return RedirectToAction("Blog","Blog");
        }
    }
}
