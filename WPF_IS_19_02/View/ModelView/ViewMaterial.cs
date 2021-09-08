﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_IS_19_02.DB;

namespace WPF_IS_19_02.View.ModelView
{
    public  class ViewMaterial
    {
        public string Image { get; set; }
        public string NameEndType { get; set; }
        public string Ostatok { get; set; }
        public string MinCol{ get; set; }
        public string Providers { get; set; }
       
        public ViewMaterial()
        {

        }

        public ViewMaterial(DB.Materials materials)
        {
            Image = @"/Image/" + materials.ImagePath;
            NameEndType = $" {materials.MaterialTypes.Name} | {materials.Name}";
            MinCol = $"Минимальное  количество {materials.MinCount} шт.";
            Ostatok = GetOstatoc(materials);
            Providers = GetProviders(materials);
        }

        public string GetProviders(Materials materials)
        {
            try
            {
                DB.dEntities entities = new dEntities();
                var s = entities.Receipts.Where(x => x.Id_Material == materials.Id).ToList();

                List<string> vs = new List<string>();

                foreach (var item in s)
                {
                    vs.Add(item.Suppliers.Name);
                }
                vs =  vs.Distinct().OrderBy(x => x).ToList();

                string content = "Поставщики: ";

                for (int i = 0; i < vs.Count; i++)
                {
                    string item = vs[i];

                    if (i==vs.Count-1)
                    {
                        content += $" {item}.";
                    }
                    else
                    {
                        content += $" {item},";
                    }
                    
                }
                return content;

            }
            catch
            {
                throw new Exception("Ошибка БД");
            }
        }

        private string GetOstatoc(Materials materials)
        {
            throw new NotImplementedException();
        }
    }
}
